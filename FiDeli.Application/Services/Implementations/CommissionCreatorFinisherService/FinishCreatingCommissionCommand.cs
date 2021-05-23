using Fideli.Domain.EventBus.Interfaces.Results;
using FiDeli.Application.DTO;
using FiDeli.Domain;
using FiDeli.Domain.Core.Commissions;
using FiDeli.Domain.EventBus.Interfaces.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.CommissionCreatorFinisherService
{
    public class FinishCreatingCommissionCommand : ICommand<Result<CommissionDTO>>
    {
        public Guid Id { get; }
        public Commission Commission { get; set; }
        public ParcelLocker TargetParcelLocker { get; set; }

        public FinishCreatingCommissionCommand(Commission commission, ParcelLocker targetParcelLocker)
        {
            Id = Guid.NewGuid();
            Commission = commission;
            TargetParcelLocker = targetParcelLocker;
        }
    }
}
