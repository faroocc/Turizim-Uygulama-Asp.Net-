using System.Collections.Generic;
using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PayManager : IPayService
    {
        IPayDal _payDal;
        public PayManager(IPayDal paydal)
        {
            _payDal=paydal;
        }
        public void TAdd(Pay t)
        {
            _payDal.Insert(t);
        }

        public void TDelete(Pay t)
        {
            throw new System.NotImplementedException();
        }

        public Pay TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Pay> TGetList()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Pay t)
        {
            throw new System.NotImplementedException();
        }
    }
}