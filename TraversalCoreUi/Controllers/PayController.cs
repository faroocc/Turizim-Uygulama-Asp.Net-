using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCoreUi.Controllers
{
    public class PayController:Controller
    {
        PayManager payManager = new PayManager(new EfPayDal());
        [HttpGet]
        public IActionResult PayPage()
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
        public IActionResult PayPage(Pay p)
        {
           p.PayDate=Convert.ToDateTime(DateTime.Now.ToShortDateString());
           p.PayStatus=true;
           p.DestinationID=2;
           p.PayTotalPrice="2000";
           payManager.TAdd(p);
          return View();
        }
    }
}