using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfRezervationDal : GenericRepository<Rezervation>, IRezervationDal
    {
        public List<Rezervation> GetListByFilter(Expression<Func<Rezervation, bool>> filter)
        {
            using var c = new Context();
            return c.Set<Rezervation>().Where(filter).ToList();
        }

        public List<Rezervation> GetListWithRezervationByAccepted(int id)
        {
             using var c = new Context();
            return c.Rezervations.Include(x=>x.Destination).Where(x=>x.Status=="Onaylandı" 
            && x.AppUserId==id).ToList();
        }

        public List<Rezervation> GetListWithRezervationByPrevious(int id)
        {
            using var c = new Context();
            return c.Rezervations.Include(x=>x.Destination).Where(x=>x.Status=="Geçmiş" 
            && x.AppUserId==id).ToList();
        }

        public List<Rezervation> GetListWithRezervationByWaitApporaval(int id)
        {
            using var c = new Context();
            return c.Rezervations.Include(x=>x.Destination).Where(x=>x.Status=="Onay bekliyor" 
            && x.AppUserId==id).ToList();
        }
    }
}