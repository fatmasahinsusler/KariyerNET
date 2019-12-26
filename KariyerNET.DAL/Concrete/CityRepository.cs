using KariyerNET.Core.DAL.EntityFramework;
using KariyerNET.DAL.Abstract;
using KariyerNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete
{
    public class CityRepository : EFRepository<City, KariyerNETDBContext>, ICityDAL
    {
    }
}
