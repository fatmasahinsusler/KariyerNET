using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model.EmployeeSide
{
    public class Login:BaseEntity
    {
        public string FirstName { get; set; } //üye girişi için yazdık silinebilir.
        public string SurName { get; set; } //üye girişi için yazdık silinebilir.
        [Required(ErrorMessage ="E-Mail kısmı boş geçilemez.")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail adresi giriniz.")]
        public string LoginMail { get; set; }
        [Required(ErrorMessage ="Şifre kısmı boş geçilemez.")]
        public string Password { get; set; }
    }
}
