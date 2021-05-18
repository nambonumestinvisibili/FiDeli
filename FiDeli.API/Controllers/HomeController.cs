using FiDeli.Infrastructure.Repos;
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
        public HomeController(IDelivererRepo delivererRepo)
        {
            _delivererRepo = delivererRepo;
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
            return sb.ToString();
        }
    }
}
