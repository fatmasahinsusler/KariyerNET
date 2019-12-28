using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
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
            _experienceDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _experienceDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Experience Get(int entityID)
        {
            return _experienceDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Experience> GetAll()
        {
            return _experienceDAL.GetAll();
        }

        public void Insert(Experience entity)
        {
            _experienceDAL.Add(entity);
        }

        public void Update(Experience entity)
        {
            _experienceDAL.Update(entity);
        }
    }
}
