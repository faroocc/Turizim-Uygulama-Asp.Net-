using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TraversalCoreUi.Models;

namespace TraversalCoreUi.Controllers
{
    public class DestinationController:Controller
    {   
       DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            
            var values = destinationManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult DestinationDetail(int id)
        {
          var values = destinationManager.TGetByID(id);
          return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetail(DestinationController p)
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}