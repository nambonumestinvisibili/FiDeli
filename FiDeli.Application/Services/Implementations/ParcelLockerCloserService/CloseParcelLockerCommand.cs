using Fideli.Domain.EventBus.Interfaces.Results;
using FiDeli.Domain;
using FiDeli.Domain.EventBus.Interfaces.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.ParcelLockerCloserService
{
    public class CloseParcelLockerCommand : ICommand<Result>
    {
        public Guid Id { get; }
        public Locker Locker { get; set; }
        public Person Executor { get; set; }
        
        public CloseParcelLockerCommand(Locker locker, Person executor)
        {
            Id = Guid.NewGuid();
            Locker = locker;
            Executor = executor;
        }
    }
}
