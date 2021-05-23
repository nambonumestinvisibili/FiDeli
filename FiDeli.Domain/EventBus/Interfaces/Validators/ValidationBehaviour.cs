using Fideli.Domain.EventBus.Interfaces.Results;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FiDeli.Domain.EventBus.Interfaces.Validators
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
        where TRequest : IRequest<TResponse>
        where TResponse : Result, new()
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest> (request);

                var failures = _validators
                    .Select(v => v.Validate(context))
                    .SelectMany(result => result.Errors)
                    .Where(f => f != null)
                    .ToList();

                if (failures.Any())
                {
                    TResponse response = new TResponse();

                    response.Set(ErrorType.NotValid, failures.Select(s => s.ErrorMessage), null);

                    return Task.FromResult<TResponse>(response);
                }
                else
                {
                    return next();
                }
            }

            return next();
        }

    }
}
