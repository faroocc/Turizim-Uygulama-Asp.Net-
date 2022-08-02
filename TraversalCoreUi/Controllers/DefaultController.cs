using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TraversalCoreUi.Models;

namespace TraversalCoreUi.Controllers
{
    public class DefaultController:Controller
    {
        public IActionResult Index()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}