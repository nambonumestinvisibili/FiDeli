using AutoMapper;
using Fideli.Domain.EventBus.Interfaces.Results;
using FiDeli.Application.DTO;
using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain.EventBus.Interfaces.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.CommissionCreatorFinisherService
{
    public class FinishCreatingCommissionCommandHandler : ICommandHandler<FinishCreatingCommissionCommand, Result<CommissionDTO>>
    {
        private readonly ICommissionRepo _commissionRepo;
        private IParcelLockerRepo _parcelLockerRepo;
        private IMapper _mapper;
        public FinishCreatingCommissionCommandHandler(ICommissionRepo commissionRepo, IParcelLockerRepo parcelLockerRepo, IMapper mapper)
        {
            _commissionRepo = commissionRepo;
            _parcelLockerRepo = parcelLockerRepo;
            _mapper = mapper;
        }

        public async Task<Result<CommissionDTO>> Handle(FinishCreatingCommissionCommand request, CancellationToken cancellationToken)
        {
            var cmdLocker = request.TargetParcelLocker;
            var cmdCommission = request.Commission;

            var dbParcelLocker = await _parcelLockerRepo.FindById(cmdLocker.Id);
            var dbCommission = await _commissionRepo.FindById(cmdCommission.Id);

            
            if (dbParcelLocker == null || dbCommission == null)
            {
                var resultx = new Result<CommissionDTO>(ErrorType.NotFound);
                return resultx;
            }

            if (cmdCommission.Parcel.CommissionerCode != dbCommission.Parcel.CommissionerCode)
            {
                return new Result<CommissionDTO>(ErrorType.WrongArguments, "Parcel Numbers do not match");
            }

            if (!dbParcelLocker.ContainsLockerOfSize(dbCommission.Parcel.Size))
            {
                var resultx = new Result<CommissionDTO>(ErrorType.NotValid, "There is no locker of given size");
                return resultx;
            }
            
            dbCommission.SourceParcelLocker = dbParcelLocker;
            dbCommission.CommissionStatus = Domain.Statuses.CommissionStatus.Executing;
            await _commissionRepo.Update(request.Commission);

            var commissionDTO = _mapper.Map<CommissionDTO>(dbCommission);
            var result = new Result<CommissionDTO>();
            result.SetOutput(commissionDTO);
            
            return result;
            
        }
    }
}
