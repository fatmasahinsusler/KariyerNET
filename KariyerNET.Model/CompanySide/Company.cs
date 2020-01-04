using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.CompanySide
{
    public class Company : BaseEntity
    {
        //public string UserName { get; set; } // E posta ile girsin
        [Required(ErrorMessage ="Şifre kısmı boş geçilemez.")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Şirket adını boş geçemezsiniz.")]
        public string CompanyName { get; set; }
        public string LogoURL { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage ="E-Mail kısmı boş geçilemez.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail adresi giriniz.")]
        public string EMail { get; set; }

        //mapping

        public virtual List<Sector> Sectors { get; set; }

        public virtual List<JobAdvert> Adverts { get; set; }

    }
}
