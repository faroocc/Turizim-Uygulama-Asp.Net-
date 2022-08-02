using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TraversalCoreUi.Controllers
{
   
    public class CommentController : Controller
    {
         CommentManager commentManager = new CommentManager(new EfCommentDal());

       [HttpGet]
        public IActionResult CommentPartial()
        {
            
            return PartialView();
        }
        [HttpPost]
        public IActionResult CommentPartial(Comment p)
        {
            p.CommentDate=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState=true;
            p.DestinationID=2;
            commentManager.TAdd(p);
            return RedirectToAction("Index","Destination");
        }

       
    }
}