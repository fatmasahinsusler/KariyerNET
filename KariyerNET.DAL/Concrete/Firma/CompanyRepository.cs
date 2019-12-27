using KariyerNET.Core.DAL.EntityFramework;
using KariyerNET.DAL.Abstract.Firma;
using KariyerNET.Model.Firma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete.Firma
{
    public class CompanyRepository : EFRepository<Company, KariyerNETDBContext>, ICompanyDAL
    {
    }
}
