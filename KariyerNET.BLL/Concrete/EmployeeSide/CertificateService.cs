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
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Certificate Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Certificate> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Certificate entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Certificate entity)
		{
			throw new NotImplementedException();
		}
	}
}
