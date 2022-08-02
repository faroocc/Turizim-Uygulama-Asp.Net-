using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace TraversalCoreUi.ViewComponents.Default
{
    public class _PayPagePartial : ViewComponent
    {
        PayManager payManager = new PayManager(new EfPayDal());
        
        public IViewComponentResult Invoke()
        {
           
           return View();        
           
        }
       
    }
}