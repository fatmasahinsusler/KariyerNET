using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.EmployeeSide
{
    public class Resume : BaseEntity//Özgeçmiş
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Title { get; set; }
        public DateTime BirtDate { get; set; }
        public string CountryCode { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }//Cinsiyet
        public DrivingLicense DrivingLicense { get; set; }//Ehliyet
        public MaritalStatus MaritalStatus { get; set; }//Medeni Hal
        public string Nation { get; set; }
        public string PhotoURL { get; set; }
        public MilitaryState MilitaryState { get; set; }

        //mapping
        public Login Login { get; set; }
        public int LoginID { get; set; } //User ID yerine loginID kullanılıyor
        public City City { get; set; }
        public int CityID { get; set; }
        public Town Town { get; set; }
        public int TownID { get; set; }

    }
    public enum DrivingLicense
    {
        Yok,
        A2,
        B
    }
    public enum MaritalStatus
    {
        Evli,
        Bekar,
        Dul
    }
    public enum Gender
    {
        Kadın,
        Erkek
    }
    public enum MilitaryState
    {
        Yapildi,
        Muaf,
        Yapilmadi
    }
}
