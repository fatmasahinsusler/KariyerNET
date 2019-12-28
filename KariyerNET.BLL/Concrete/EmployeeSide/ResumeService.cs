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
            _resumeDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _resumeDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Resume Get(int entityID)
        {
            return _resumeDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Resume> GetAll()
        {
            return _resumeDAL.GetAll();
        }

        public void Insert(Resume entity)
        {
            _resumeDAL.Add(entity);
        }

        public void Update(Resume entity)
        {
            _resumeDAL.Update(entity);
        }
    }
}
