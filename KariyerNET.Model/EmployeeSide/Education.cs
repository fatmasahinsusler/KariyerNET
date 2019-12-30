using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.EmployeeSide
{
   public class Education:BaseEntity
    {
        //Eğitim
       
        public EducationLevel EducationLevel { get; set; } //Eğitim derecesi
        public string SchoolName { get; set; }
        public string Section { get; set; }
        public TypeOfEducation TypeOfEducation { get; set; } //Egitim tipi
        public string GraduationNote { get; set; } //Bitirme derecesi
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }

        //mapping
           
        public virtual int ResumeID { get; set; }
        public virtual Resume Resume { get; set; }


    }
    public enum EducationLevel
    {
        Yok,
        Lise,       
        OnLisans,
        Lisans,
        YuksekLisans
    }
    public enum TypeOfEducation
    {
        OrgunOgretim,
        AcikOgretim,
        UzaktanEgitim
    }
}
