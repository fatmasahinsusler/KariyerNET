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
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public City Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<City> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(City entity)
		{
			throw new NotImplementedException();
		}

		public void Update(City entity)
		{
			throw new NotImplementedException();
		}
	}
}
