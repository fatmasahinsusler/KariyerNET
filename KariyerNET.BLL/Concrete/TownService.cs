using KariyerNET.DAL.Abstract;
using KariyerNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract
{
	public class TownService : ITownService
	{
        ITownDAL _townDAL;

        public TownService(ITownDAL townDAL)
        {
            _townDAL = townDAL;
        }
		public void Delete(Town entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Town Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Town> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Town entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Town entity)
		{
			throw new NotImplementedException();
		}
	}
}
