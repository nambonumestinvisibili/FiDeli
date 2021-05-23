using FiDeli.Application.Services.Implementations.CommissionCreatorService;
using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using FiDeli.Domain.Core.Commissions;
using FiDeli.Infrastructure;
using FiDeli.Infrastructure.Repos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.API.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : Controller
    {
        private readonly IDelivererRepo _delivererRepo;
        private readonly ICommissionRepo _commissionRepo;
        private readonly IMediator _mediator;
        public HomeController(IDelivererRepo delivererRepo, IMediator mediator, ICommissionRepo commissionRepo)
        {
            _delivererRepo = delivererRepo;
            _mediator = mediator;
            _commissionRepo = commissionRepo;
        }

        [HttpGet]
        public async Task<string> Index()
        {

            //Commission commission = new Commission() { Price = 10 };
            //var ret = await _mediator.Send(new CreateCommissionCommand(commission));
            //return ret.Output.Price.ToString();

            return "";
            
        }
    }
}
