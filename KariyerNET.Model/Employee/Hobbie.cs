using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model
{
    public class Hobbie:BaseEntity
    {
        public string HobbieName { get; set; }

        //mapping
        public int ResumeID { get; set; }
        public Resume Resume { get; set; }
    }
}
