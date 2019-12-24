using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model
{
    public class Certificate:BaseEntity
    {
        public string CertificateCode { get; set; }
        public string CertificateName { get; set; }
        public string Corporation { get; set; } //kurum
        public DateTime ReceiptDate { get; set; }  //alındığı tarih
        public string Description { get; set; }

        //nav prop
        public int ResumeID { get; set; }
        public Resume Resume { get; set; }
    }
}
