using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class EducationService : IEducationService
	{
        IEducationDAL _educationDAL;
        public EducationService(IEducationDAL educationDAL)
        {
            _educationDAL = educationDAL;
        }
		public void Delete(Education entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Education Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Education> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Education entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Education entity)
		{
			throw new NotImplementedException();
		}
	}
}
