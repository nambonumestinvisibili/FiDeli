using AutoMapper;
using Fideli.Domain.EventBus.Interfaces.Results;
using FiDeli.Application.DTO;
using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain.EventBus.Interfaces.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.CommissionCreatorService
{
    public class CreateCommissionCommandHandler : ICommandHandler<CreateCommissionCommand, Result<CommissionDTO>>
    {
        private readonly ICommissionRepo _repo;
        private readonly IMapper _mapper;


        public CreateCommissionCommandHandler(ICommissionRepo commissionRepo, IMapper mapper)
        {
            _repo = commissionRepo;
            _mapper = mapper;
        }

        public async Task<Result<CommissionDTO>> Handle(CreateCommissionCommand request, CancellationToken cancellationToken)
        {
            await _repo.Add(request.Commission);
            var res = _mapper.Map<CommissionDTO>(request.Commission);
            var result = new Result<CommissionDTO>();
            result.SetOutput(res);
            return result;
        }
    }

}
