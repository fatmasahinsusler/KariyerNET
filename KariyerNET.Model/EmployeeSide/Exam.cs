using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.EmployeeSide
{
   public class Exam:BaseEntity
    {
        public string Question1 { get; set; }
        public string Answer1A { get; set; }
        public string Answer1B { get; set; }
        public string Answer1C { get; set; }
        public string Answer1D { get; set; }
        public string CorrectAnswer1 { get; set; }

        public string Question2 { get; set; }
        public string Answer2A { get; set; }
        public string Answer2B { get; set; }
        public string Answer2C { get; set; }
        public string Answer2D { get; set; }
        public string CorrectAnswer2 { get; set; }


        public string Question3 { get; set; }
        public string Answer3A { get; set; }
        public string Answer3B { get; set; }
        public string Answer3C { get; set; }
        public string Answer3D { get; set; }
        public string CorrectAnswer3 { get; set; }

        public virtual List<ExamInfo> ExamInfos { get; set; }

    }
}
