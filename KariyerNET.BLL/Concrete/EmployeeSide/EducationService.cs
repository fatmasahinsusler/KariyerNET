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
    public class EducationService : IEducationService
    {
        IEducationDAL _educationDAL;
        public EducationService(IEducationDAL educationDAL)
        {
            _educationDAL = educationDAL;
        }
        public void Delete(Education entity)
        {
            _educationDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _educationDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Education Get(int entityID)
        {
            return _educationDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Education> GetAll()
        {
            return _educationDAL.GetAll();
        }

        public void Insert(Education entity)
        {
            _educationDAL.Add(entity);
        }

        public void Update(Education entity)
        {
            _educationDAL.Update(entity);
        }
    }
    {
    }
}
