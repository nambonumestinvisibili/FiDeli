using AutoMapper;
using Fideli.Domain.EventBus.Interfaces.Results;
using FiDeli.Application.DTOs;
using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using FiDeli.Domain.EventBus.Interfaces.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.ParcelLockerOpenerService
{
    public class OpenLockerCommandHandler : ICommandHandler<OpenLockerCommand, Result<LockerDTO>>
    {
        private readonly IParcelLockerRepo _parcelLockerRepo;
        private readonly ICommissionRepo _commissionRepo;
        private readonly IMapper _mapper;

        private double CLOSE_DISTANCE = 100;
        public OpenLockerCommandHandler(
            IParcelLockerRepo parcelLockerRepo, 
            ICommissionRepo commissionRepo,
            IMapper mapper
            )
        {
            _parcelLockerRepo = parcelLockerRepo;
            _commissionRepo = commissionRepo;
            _mapper = mapper;
        }

        public async Task<Result<LockerDTO>> Handle(OpenLockerCommand request, CancellationToken cancellationToken)
        {
            var executor = request.Executor;
            var commission = _commissionRepo.FindCommissionByParcelCode(request.ParcelCode);

            if (commission == null)
            {
                return new Result<LockerDTO>(ErrorType.NotFound, "No commission with parcel of given parcel code");
            }

            if (!commission.SourceParcelLocker.IsClose(executor.CurrentLocation, CLOSE_DISTANCE))
            {
                return new Result<LockerDTO>(ErrorType.NotFound, "Not in the proximity of parcel locker");
            }

            var locker = commission.SourceParcelLocker.GetLockerByParcelCode(request.ParcelCode);

            if (locker == null)
            {
                return new Result<LockerDTO>(ErrorType.NotFound, "This parcel locker does not have the parcel");
            }

            if (executor.GetType() == typeof(Commissioner) && locker.CanBeOpenedBy<Commissioner>(request.ParcelCode))
            {
                locker.Open();
                locker.LoadLocker(commission.Parcel);
                commission.DeliveryStatus = DeliveryStatus.SubmittedByCommissioner;
            }
            else if (executor.GetType() == typeof(Deliverer) && locker.CanBeOpenedBy<Deliverer>(request.ParcelCode))
            {
                locker.Open();
                locker.EmptyLocker();
                commission.DeliveryStatus = DeliveryStatus.Traveling;

            }
            else if (executor.GetType() == typeof(Recipient) && locker.CanBeOpenedBy<Recipient>(request.ParcelCode)){
                locker.Open();
                locker.EmptyLocker();
                commission.CommissionStatus = Domain.Statuses.CommissionStatus.Finished;
            }

            await _commissionRepo.Update(commission);

            return new Result<LockerDTO>().SetOutput(_mapper.Map<LockerDTO>(locker));
        }
    }
}
