using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstarct
{
    public interface IContactService: IGenericService<Contact>
    {
        List<Contact> TGetListWithDestination();
         
    }
}