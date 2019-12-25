using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.Company
{
    public class JobAdvert : BaseEntity
    {
        public string AdvertHead { get; set; }//ilan başlığı
        public string Title { get; set; } //pozisyon
        public string Description { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public List<Perfection> Perfections { get; set; }
        public List<Exam> Exams { get; set; }
        public bool IsExamNeeded { get; set; }
        public List<Language> Languages { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<City> Cities { get; set; }
        public List<Town> Towns { get; set; }
        public int NeededEmployeeCount { get; set; } // Pozisyon için alınacak kişi sayısı
        public MilitaryState MilitaryState { get; set; }
    }
}
