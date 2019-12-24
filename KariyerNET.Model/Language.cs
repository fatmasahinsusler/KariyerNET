using KariyerNET.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.Model
{
    public class Language:BaseEntity
    {
        public string LanguageName { get; set; }
        public string LanguageLevel { get; set; }

        //nav prop
        public int ResumeID { get; set; }


        public Resume Resume { get; set; }
    }
}
