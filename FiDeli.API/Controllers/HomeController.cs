using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
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
        private readonly IMediator _mediator;
        public HomeController(IDelivererRepo delivererRepo, IMediator mediator)
        {
            _delivererRepo = delivererRepo;
            _mediator = mediator;
        }

        [HttpGet]
        public string Index()
        {
            StringBuilder sb = new StringBuilder();
            var r = _delivererRepo.FindAll().Result; 
            foreach (var x in r)
            {
                sb.Append(x);
            }

            _mediator.Send(new SomeEvent("działa!"));

            return sb.ToString();
        }
    }
}
