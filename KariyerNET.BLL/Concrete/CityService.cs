using KariyerNET.DAL.Abstract;
using KariyerNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract
{
	public class CityService : ICityService
	{
        ICityDAL _cityDAL;

        public CityService(ICityDAL cityDAL)
        {
            _cityDAL = cityDAL;
        }
        public void Delete(City entity)
        {
            _cityDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _cityDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public City Get(int entityID)
        {
            return _cityDAL.Get(a => a.ID == entityID);
        }

        public ICollection<City> GetAll()
        {
            return _cityDAL.GetAll();
        }

        public void Insert(City entity)
        {
            _cityDAL.Add(entity);
        }

        public void Update(City entity)
        {
            _cityDAL.Update(entity);
        }
    }
}
