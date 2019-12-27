using KariyerNET.DAL.Abstract.Employee;
using KariyerNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.Employee
{
	public class ExamInfoService : IExamInfoService
	{
        IExamInfoDAL _examInfoDAL;
        public ExamInfoService(IExamInfoDAL examInfoDAL)
        {
            _examInfoDAL = examInfoDAL;
        }
		public void Delete(ExamInfo entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public ExamInfo Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<ExamInfo> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(ExamInfo entity)
		{
			throw new NotImplementedException();
		}

		public void Update(ExamInfo entity)
		{
			throw new NotImplementedException();
		}
	}
}
