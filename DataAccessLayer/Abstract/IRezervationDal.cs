using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IRezervationDal:IGenericDal<Rezervation>
    {
        List<Rezervation> GetListByFilter(Expression<Func<Rezervation,bool>> filter); 

        List<Rezervation> GetListWithRezervationByWaitApporaval(int id);
        List<Rezervation> GetListWithRezervationByAccepted(int id);
        List<Rezervation> GetListWithRezervationByPrevious(int id);
    }
}