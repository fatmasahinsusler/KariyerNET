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
	public class CompanyService : ICompanyService
	{
		ICompanyDAL _companyDAL;

		public CompanyService(ICompanyDAL CompanyDAL)
		{
			_companyDAL = CompanyDAL;
		}

		public Company CompanyLogin(string mail, string password)
		{
			if (_companyDAL.Get(a => a.EMail == mail) != null)
			{
				if (_companyDAL.Get(a => a.EMail == mail).Password == password)
				{
					return _companyDAL.Get(a => a.EMail == mail);
				}
			}
			return null;
		}

		public void Delete(Company entity)
		{
			_companyDAL.Delete(entity);
		}

		public void DeleteById(int entityID)
		{
			var entity = _companyDAL.Get(a => a.ID == entityID);
			Delete(entity);
		}

		public Company Get(int entityID)
		{
			return _companyDAL.Get(a => a.ID == entityID);
		}

		public ICollection<Company> GetAll()
		{
			return _companyDAL.GetAll();
		}

		public Company GetByMail(string mail)
		{
			return _companyDAL.Get(a => a.EMail == mail);
		}

		public void Insert(Company entity)
		{
			_companyDAL.Add(entity);
		}

		public void Update(Company entity)
		{
			_companyDAL.Update(entity);
		}



	}
}
