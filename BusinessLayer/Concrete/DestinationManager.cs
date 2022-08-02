using System.Collections.Generic;
using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationdal;
        public DestinationManager(IDestinationDal destinationdal)
        {
            _destinationdal = destinationdal;
        }
        public void TAdd(Destination t)
        {
            _destinationdal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationdal.Delete(t);
        }
        public Destination TGetByID(int id)
        {
             return _destinationdal.GetByID(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationdal.GetList();
        }

        public void TUpdate(Destination t)
        {
            _destinationdal.Update(t);
        }

        Destination IGenericService<Destination>.TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}