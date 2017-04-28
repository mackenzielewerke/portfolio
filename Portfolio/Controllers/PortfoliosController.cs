﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Portfolio.Controllers
{
    public class PortfoliosController : Controller
    {
        [HttpGet("~/portfolio")]
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
