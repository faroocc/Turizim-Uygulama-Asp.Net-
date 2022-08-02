using System.Collections.Generic;
using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class TestiminoalsManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;
        public TestiminoalsManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal=testimonialDal;
        }

        public void TAdd(Testimonial t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new System.NotImplementedException();
        }

        public Testimonial TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
           return _testimonialDal.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            throw new System.NotImplementedException();
        }
    }
}