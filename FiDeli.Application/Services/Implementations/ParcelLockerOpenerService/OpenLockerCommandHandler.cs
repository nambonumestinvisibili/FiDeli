using Fideli.Domain.EventBus.Interfaces.Results;
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
    public class OpenLockerCommandHandler : ICommandHandler<OpenLockerCommand, Result>
    {
        private readonly IParcelLockerRepo _parcelLockerRepo;

        public OpenLockerCommandHandler(IParcelLockerRepo parcelLockerRepo)
        {
            _parcelLockerRepo = parcelLockerRepo;
        }

        public Task<Result> Handle(OpenLockerCommand request, CancellationToken cancellationToken)
        {
            var executor = request.Executor;

            

        }
    }
}
