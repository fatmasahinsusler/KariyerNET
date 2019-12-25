using KariyerNET.Core.Entity;
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
        public Town Towns { get; set; }
        public int TownID { get; set; }

    }
}
