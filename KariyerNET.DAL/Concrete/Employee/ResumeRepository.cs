using KariyerNET.Core.DAL.EntityFramework;
using KariyerNET.DAL.Abstract.Employee;
using KariyerNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete.Employee
{
    public class ResumeRepository : EFRepository<Resume, KariyerNETDBContext>, IResumeDAL
    {
    }
}
