﻿using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Implementations.CommissionCreatorService
{
    public class CreateCommissionCommandValidator : AbstractValidator<CreateCommissionCommand>
    {
        public CreateCommissionCommandValidator()
        {
            //RuleFor(cmd => cmd.Commission.Recipient).NotNull();
        }
    }
}
