using KariyerNET.DAL.Abstract.Employee;
using KariyerNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.Employee
{
	public class ExperienceService : IExperienceService
	{
        IExperienceDAL _experienceDAL;
        public ExperienceService(IExperienceDAL experienceDAL)
        {
            _experienceDAL = experienceDAL;
        }
		public void Delete(Experience entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Experience Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Experience> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Experience entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Experience entity)
		{
			throw new NotImplementedException();
		}
	}
}
