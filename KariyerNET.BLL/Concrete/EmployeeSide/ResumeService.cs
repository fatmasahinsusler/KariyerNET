using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class ResumeService : IResumeService
	{
        IResumeDAL _resumeDAL;

        public ResumeService(IResumeDAL resumeDAL)
        {
            _resumeDAL = resumeDAL;
        }
		public void Delete(Resume entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Resume Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Resume> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Resume entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Resume entity)
		{
			throw new NotImplementedException();
		}
	}
}
