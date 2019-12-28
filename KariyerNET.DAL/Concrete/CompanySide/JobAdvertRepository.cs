using KariyerNET.Core.DAL.EntityFramework;
using KariyerNET.DAL.Abstract.CompanySide;
using KariyerNET.Model.CompanySide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete.CompanySide
{
    public class JobAdvertRepository : EFRepository<JobAdvert, KariyerNETDBContext>, IJobAdvertDAL
    {
    }
}
