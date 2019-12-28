using KariyerNET.BLL.Abstract.CompanySide;
using KariyerNET.DAL.Abstract.CompanySide;
using KariyerNET.Model.CompanySide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Concrete.CompanySide
{
    public class JobAdvertService : IJobAdvertService
    {
        IJobAdvertDAL _jobAdvertDAL;

        public JobAdvertService(IJobAdvertDAL jobAdvertDAL)
        {
            _jobAdvertDAL = jobAdvertDAL;
        }

        public void Delete(JobAdvert entity)
        {
            _jobAdvertDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _jobAdvertDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public JobAdvert Get(int entityID)
        {
            return _jobAdvertDAL.Get(a => a.ID == entityID);
        }

        public ICollection<JobAdvert> GetAll()
        {
            return _jobAdvertDAL.GetAll();
        }

        public void Insert(JobAdvert entity)
        {
            _jobAdvertDAL.Add(entity);
        }

        public void Update(JobAdvert entity)
        {
            _jobAdvertDAL.Update(entity);
        }
    }
}
