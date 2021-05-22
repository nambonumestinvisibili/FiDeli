using FiDeli.Application.DTO;
using FiDeli.Domain.Core.Commissions;
using FiDeli.Domain.EventBus.Interfaces.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.CommissionCreatorService
{
    public class CreateCommissionCommand : ICommand<CommissionDTO>
    {
        public Guid Id  { get; }
        public Commission Commission { get; set; }

        public CreateCommissionCommand(Commission commission)
        {
            Id = Guid.NewGuid();
            Commission = commission;
        }

    }
}
