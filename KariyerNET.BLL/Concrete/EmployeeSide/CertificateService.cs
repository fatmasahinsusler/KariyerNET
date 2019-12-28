using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class CertificateService : ICertificateService
	{
        ICertificateDAL _certificateDAL;

        public CertificateService(ICertificateDAL certificateDAL)
        {
            _certificateDAL = certificateDAL;
        }
        public void Delete(Certificate entity)
        {
            _certificateDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _certificateDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Certificate Get(int entityID)
        {
            return _certificateDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Certificate> GetAll()
        {
            return _certificateDAL.GetAll();
        }

        public void Insert(Certificate entity)
        {
            _certificateDAL.Add(entity);
        }

        public void Update(Certificate entity)
        {
            _certificateDAL.Update(entity);
        }
    }
}
