using KariyerNET.Core.Entity;
using KariyerNET.Model.CompanySide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model
{
  public  class City:BaseEntity
    {
        public string CityName { get; set; }
        public virtual List<Town> Towns { get; set; }      
        public virtual List<JobAdvert> jobAdverts { get; set; }

    }
}
