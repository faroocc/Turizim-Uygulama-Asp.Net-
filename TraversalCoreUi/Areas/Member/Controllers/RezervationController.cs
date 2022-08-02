using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace TraversalCoreUi.Areas.Member.Controllers
{
    [Area("Member")]
   
    public class RezervationController : Controller
    {
        RezervationManager _rezervationManager = new RezervationManager(new EfRezervationDal());
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private readonly UserManager<AppUser> _userManager;

        public RezervationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
       
        public async Task<IActionResult> MyCurrentRezervation()
        {
          var values = await _userManager.FindByNameAsync(User.Identity.Name);
          var valueslist= _rezervationManager.TGetListWithAcceptedApporoval(values.Id); 
          return View(valueslist);
          
        }
        public async Task<IActionResult> MyOldRezervation()
        {
          var values = await _userManager.FindByNameAsync(User.Identity.Name);
          var valueslist= _rezervationManager.TGetListWithPreviousApporoval(values.Id); 
          return View(valueslist);
          
        }
        public async Task<IActionResult> MyApporovalRezervation(int id)
        {
          var values = await _userManager.FindByNameAsync(User.Identity.Name);
          var valueslist= _rezervationManager.TGetListWithWaitApporoval(values.Id); 
          return View(valueslist);
        }
        [HttpGet]
        public IActionResult NewRezervation()
        {
           
            List<SelectListItem> yerler = (from x in destinationManager.TGetList()
                                            select new SelectListItem
                                            {
                                                Text=x.City,
                                                Value=x.DestinationID.ToString()
                                            }).ToList();
            ViewBag.cv = yerler; 
            return View();
        }
        [HttpPost]
        public IActionResult NewRezervation(Rezervation p)
        {
              
            List<SelectListItem> yerler = (from x in destinationManager.TGetList()
                                            select new SelectListItem
                                            {
                                                Text=x.City,
                                                Value=x.DestinationID.ToString()
                                            }).ToList();
             ViewBag.cv = yerler;                                
             p.AppUserId=2;
            _rezervationManager.TAdd(p);
            return View();
     
        }

        
    }
}