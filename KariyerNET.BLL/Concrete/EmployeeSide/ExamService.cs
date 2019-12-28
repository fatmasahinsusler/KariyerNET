using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class ExamService : IExamService
	{
        IExamDAL _examDAL;
        public ExamService(IExamDAL examDAL)
        {
            _examDAL = examDAL;
        }
		public void Delete(Exam entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Exam Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Exam> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Exam entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Exam entity)
		{
			throw new NotImplementedException();
		}
	}
}
