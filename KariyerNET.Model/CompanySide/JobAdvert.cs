using KariyerNET.Core.Entity;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.CompanySide
{
    public class JobAdvert : BaseEntity
    {
        [Required]
        public string AdvertHead { get; set; }//ilan başlığı
        //[Required]
        public string Title { get; set; } //pozisyon
        [Required]
        public string Description { get; set; }
        [Required]
        public int NeededEmployeeCount { get; set; } // Pozisyon için alınacak kişi sayısı
        public bool IsExamNeeded { get; set; }
        [Required]
        public int Experiences { get; set; }
        //[Required]
        public MilitaryState MilitaryState { get; set; }
        //[Required]
        public EducationLevel EducationLevel { get; set; }

        //nav props
        public virtual List<Exam> Exams { get; set; }
        public virtual List<Language> Languages { get; set; }
        public virtual List<City> Cities { get; set; }
        public virtual List<Town> Towns { get; set; }
        public virtual List<Perfection> Perfections { get; set; }
        public virtual int? CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public virtual List<Sector> Sectors { get; set; }
        public virtual List<Resume> Resumes { get; set; }
    }
}
