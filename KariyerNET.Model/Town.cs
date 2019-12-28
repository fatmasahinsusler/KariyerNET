using KariyerNET.Core.Entity;
using KariyerNET.Model.CompanySide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model
{
   public class Town:BaseEntity
    {
        public string TownName { get; set; }

        //Mapping
        public City City { get; set; }
        public int CityID { get; set; }
        public List<JobAdvert> jobAdverts { get; set; }

    }
}
