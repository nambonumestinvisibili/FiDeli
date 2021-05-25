using Fideli.Domain.EventBus.Interfaces.Results;
using FiDeli.Domain;
using FiDeli.Domain.EventBus.Interfaces.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.ParcelLockerCloserService
{
    public class CloseParcelLockerCommandHandler : ICommandHandler<CloseParcelLockerCommand, Result>
    {
        public  Task<Result> Handle(CloseParcelLockerCommand request, CancellationToken cancellationToken)
        {
            //var locker = request.Locker;
            //var executor = request.Executor;
            //if (executor.GetType() == typeof(Commissioner))
            //{
            //    if (locker.EnsureContains())
            //    {
            //        locker.Close();
            //    }
            //    else
            //    {
            //        return new Result(ErrorType.NotValid, "locker is empty");
            //    }
            //}
            //else if (executor.GetType() == typeof(Recipient))
            //{
            //    if (locker.EnsureEmpty())
            //    {
            //        locker.Close();
            //    }
            //    else
            //    {
            //        return new Result(ErrorType.NotValid, "locker contains the package!");
            //    }
            //}
            //else if (executor.GetType() == typeof(Deliverer))
            //{
            //    if ((executor as Deliverer).ParcelsInPossession.Contains(locker.CurrentParcel))
            //    {
            //        locker.EnsureContains();
            //    }
            //}
            //return new Result();

            return Task.FromResult(new Result());
        }
    }
}
