using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreUi.ViewComponents.Default
{
    public class _Testiminoal : ViewComponent
    {
        TestiminoalsManager testiminoalsManager = new TestiminoalsManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testiminoalsManager.TGetList();                  
            return View(values);
        }
    }
}