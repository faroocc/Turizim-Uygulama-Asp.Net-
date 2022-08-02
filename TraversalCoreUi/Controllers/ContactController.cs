using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace TraversalCoreUi.Controllers
{

    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
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
        public IActionResult Index(Contact p)
        {
            DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
            List<SelectListItem> yerler = (from x in destinationManager.TGetList()
                                            select new SelectListItem
                                            {
                                                Text=x.City,
                                                Value=x.DestinationID.ToString()
                                            }).ToList();
             ViewBag.cv = yerler;
            p.Status=true;
            p.Description="2 haftalık fiyat alamak istioyrum";
            contactManager.TAdd(p);
            return View();
        }

    }
}