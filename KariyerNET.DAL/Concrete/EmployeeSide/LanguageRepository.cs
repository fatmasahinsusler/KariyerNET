using KariyerNET.Core.DAL.EntityFramework;
using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete.EmployeeSide
{
    public class LanguageRepository : EFRepository<Language, KariyerNETDBContext>, ILanguageDAL
    {
    }
}
