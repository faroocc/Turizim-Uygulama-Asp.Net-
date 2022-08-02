using System.Collections.Generic;
using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class RezervationManager : IRezervationService
    {
        IRezervationDal _rezervationDal;
        public RezervationManager(IRezervationDal rezervationDal)
        {
            _rezervationDal=rezervationDal;
        }

        public void TAdd(Rezervation t)
        {
            _rezervationDal.Insert(t);
        }

        public void TDelete(Rezervation t)
        {
            throw new System.NotImplementedException();
        }

        public Rezervation TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Rezervation> TGetList()
        {
            return _rezervationDal.GetList();
        }

        public List<Rezervation> TGetListWithAcceptedApporoval(int id)
        {
            return _rezervationDal.GetListWithRezervationByAccepted(id);
        }

        public List<Rezervation> TGetListWithActive(int id)
        {
            return _rezervationDal.GetListByFilter(x=>x.AppUserId==id && x.Status =="Onay Bekliyor");
        }

        public List<Rezervation> TGetListWithPreviousApporoval(int id)
        {
            return _rezervationDal.GetListWithRezervationByPrevious(id);
        }

        public List<Rezervation> TGetListWithWaitApporoval(int id)
        {
            return _rezervationDal.GetListWithRezervationByWaitApporaval(id);
        }

        public void TUpdate(Rezervation t)
        {
            throw new System.NotImplementedException();
        }
    }
}