using System.Collections.Generic;
using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _SubAboutDal;
        public SubAboutManager(ISubAboutDal subaboutdal)
        {
            _SubAboutDal=subaboutdal;
        }

        public void TAdd(SubAbout t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(SubAbout t)
        {
            throw new System.NotImplementedException();
        }

        public SubAbout TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _SubAboutDal.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            throw new System.NotImplementedException();
        }
    }
}