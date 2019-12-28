using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class PerfectionService : IPerfectionService
	{
        IPerfectionDAL _perfectionDAL;

        public PerfectionService(IPerfectionDAL perfectionDAL)
        {
            _perfectionDAL = perfectionDAL;
        }
		public void Delete(Perfection entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Perfection Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Perfection> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Perfection entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Perfection entity)
		{
			throw new NotImplementedException();
		}
	}
}
