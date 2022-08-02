using System.Collections.Generic;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IContactDal:IGenericDal<Contact>
    {
         List<Contact> GetListWithDestination();
    }
}