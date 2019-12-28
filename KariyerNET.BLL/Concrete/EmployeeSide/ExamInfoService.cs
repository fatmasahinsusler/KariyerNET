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
    public class ExamInfoService : IExamInfoService
    {
        IExamInfoDAL _examInfoDAL;
        public ExamInfoService(IExamInfoDAL examInfoDAL)
        {
            _examInfoDAL = examInfoDAL;
        }
        public void Delete(ExamInfo entity)
        {
            _examInfoDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _examInfoDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public ExamInfo Get(int entityID)
        {
            return _examInfoDAL.Get(a => a.ID == entityID);
        }

        public ICollection<ExamInfo> GetAll()
        {
            return _examInfoDAL.GetAll();
        }

        public void Insert(ExamInfo entity)
        {
            _examInfoDAL.Add(entity);
        }

        public void Update(ExamInfo entity)
        {
            _examInfoDAL.Update(entity);
        }
    }
}
