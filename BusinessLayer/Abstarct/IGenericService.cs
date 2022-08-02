using System.Collections.Generic;

namespace BusinessLayer.Abstarct
{
    public interface IGenericService<T>
    {
         void TAdd(T t);
         void TDelete(T t);
         void TUpdate(T t);
         List<T> TGetList();
         T TGetByID(int id);
    }
}