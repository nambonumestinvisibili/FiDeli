using FiDeli.Domain.EventBus.Interfaces.Commands;
using FiDeli.Domain.EventBus.Interfaces.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace FiDeli.Infrastructure
{
    public class SomeEvent : ICommand
    {
        public SomeEvent(string msg)
        {
            Message = msg;
        }

        public string Message { get; set; }

        public Guid Id => Guid.NewGuid();
    }

    public class Handler1 : ICommandHandler<SomeEvent>
    {
        public Task<Unit> Handle(SomeEvent request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("whaaaaaaaaaaaaaaaaaaaaaat");
        }
    }
}
