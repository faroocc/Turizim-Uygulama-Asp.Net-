using System.Collections.Generic;
using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
           _featureDal=featureDal; 
        }
        public void TAdd(Feature t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Feature t)
        {
            throw new System.NotImplementedException();
        }

        public Feature TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            throw new System.NotImplementedException();
        }
    }
}