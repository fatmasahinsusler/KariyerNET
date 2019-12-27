using KariyerNET.DAL.Abstract.Company;
using KariyerNET.Model.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.Company
{
	public class CompanyService : ICompanyService
	{
		ICompanyDAL _companyDAL;
		public CompanyService(ICompanyDAL CompanyDAL)
		{
			_companyDAL = CompanyDAL;
		}
		public void Delete(Model.Company.Company entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Model.Company.Company Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Model.Company.Company> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Model.Company.Company entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Model.Company.Company entity)
		{
			throw new NotImplementedException();
		}
	}
}
