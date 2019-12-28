using KariyerNET.Core.Entity;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.CompanySide
{
    public class JobAdvert : BaseEntity
    {
        public string AdvertHead { get; set; }//ilan başlığı
        public string Title { get; set; } //pozisyon
        public string Description { get; set; }
        public int NeededEmployeeCount { get; set; } // Pozisyon için alınacak kişi sayısı
        public bool IsExamNeeded { get; set; }
        public int Experiences { get; set; }
        public MilitaryState MilitaryState { get; set; }
        public EducationLevel EducationLevel { get; set; }

        //nav props
        public List<Exam> Exams { get; set; }
        public List<Language> Languages { get; set; }
        public List<City> Cities { get; set; }
        public List<Town> Towns { get; set; }
        public List<Perfection> Perfections { get; set; }
        public int CompanyID { get; set; }
        public Company Company { get; set; }
        public List<Sector> Sectors { get; set; }
        public List<Resume> Resumes { get; set; }
    }
}
