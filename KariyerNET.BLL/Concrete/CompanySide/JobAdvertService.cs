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
            throw new NotImplementedException();
        }

        public void DeleteById(int entityID)
        {
            throw new NotImplementedException();
        }

        public JobAdvert Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<JobAdvert> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(JobAdvert entity)
        {
            throw new NotImplementedException();
        }

        public void Update(JobAdvert entity)
        {
            throw new NotImplementedException();
        }
    }
}
