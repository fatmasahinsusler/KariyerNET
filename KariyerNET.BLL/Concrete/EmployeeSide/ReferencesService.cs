using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class ReferencesService : IReferencesService
	{
        IReferencesDAL _referencesDAL;

        public ReferencesService(IReferencesDAL referencesDAL)
        {
            _referencesDAL = referencesDAL;
        }
		public void Delete(References entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public References Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<References> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(References entity)
		{
			throw new NotImplementedException();
		}

		public void Update(References entity)
		{
			throw new NotImplementedException();
		}
	}
}
