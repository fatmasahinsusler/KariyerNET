using KariyerNET.Core.DAL.EntityFramework;
using KariyerNET.DAL.Abstract.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete.Company
{
    public class CompanyRepository : EFRepository<Model.Company.Company, KariyerNETDBContext>, ICompanyDAL
    {
    }
}
