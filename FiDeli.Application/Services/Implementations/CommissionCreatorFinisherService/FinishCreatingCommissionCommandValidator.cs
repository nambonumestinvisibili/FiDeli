using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.CommissionCreatorFinisherService
{
    public class FinishCreatingCommissionCommandValidator : AbstractValidator<FinishCreatingCommissionCommand>
    {
        
        public FinishCreatingCommissionCommandValidator()
        {
            RuleFor(cmd => cmd.Commission.Id).NotNull();
            


        }
    }
}
