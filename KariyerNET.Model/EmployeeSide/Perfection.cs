using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.EmployeeSide
{
    public class Perfection:BaseEntity
    {
        //Yetkinlik
        public string PerfectionName { get; set; }
        //nav prop
        public virtual int ResumeID { get; set; }
        public virtual Resume Resume{ get; set; }
    }
}
