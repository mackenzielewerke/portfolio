using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Controllers
{
    public class PortfoliosController : Controller
    {
        [Route("~/portfolio")]
        [HttpGet]
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
