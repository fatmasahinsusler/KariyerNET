using KariyerNET.BLL.Abstract.Firma;
using KariyerNET.DAL.Abstract.Firma;
using KariyerNET.Model.Firma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Concrete.Firma
{
    public class CompanyService : ICompanyService
    {
        ICompanyDAL _companyDAL;

        public CompanyService(ICompanyDAL CompanyDAL)
        {
            _companyDAL = CompanyDAL;
        }

        public void Delete(Company entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int entityID)
        {
            throw new NotImplementedException();
        }

        public Company Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Company entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
