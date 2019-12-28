using KariyerNET.BLL.Abstract.EmployeeSide;
using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Concrete.EmployeeSide
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
            _examDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _examDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Exam Get(int entityID)
        {
            return _examDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Exam> GetAll()
        {
            return _examDAL.GetAll();
        }

        public void Insert(Exam entity)
        {
            _examDAL.Add(entity);
        }

        public void Update(Exam entity)
        {
            _examDAL.Update(entity);
        }
    }
}
