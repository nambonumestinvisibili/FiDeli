using Fideli.Domain.EventBus.Interfaces.Results;
using FiDeli.Domain;
using FiDeli.Domain.Core;
using FiDeli.Domain.EventBus.Interfaces.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.ParcelLockerOpenerService
{
    public class OpenLockerCommand : ICommand<Result>
    {
        public Guid Id { get; }
        public ParcelCode ParcelCode { get; set; }
        public Person Executor { get; set; }

        public OpenLockerCommand(ParcelCode code, Person executor)
        {
            Id = Guid.NewGuid();
            ParcelCode = code;
            Executor = executor;
        }

    }
}
