using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.EmployeeSide
{
    public class ExamInfo : BaseEntity
    {

        public string ExamName { get; set; }
        public ExamType ExamType { get; set; }
        public decimal Score { get; set; }
        public DateTime CreatedDate { get; set; } // sınavın oluşturulma tarihi - atanma tarihi
        public DateTime CompletedDate { get; set; } // tamamlanma tarihi

        //mapping 
        public int ExamID { get; set; }

        public Exam Exam { get; set; }
        public int LoginID { get; set; }
        public Login Login { get; set; } //User ID yerine loginID kullanılıyor

    }
    public enum ExamType
    {
        TeknikSinav,
        GenelYetenek
    }
}
