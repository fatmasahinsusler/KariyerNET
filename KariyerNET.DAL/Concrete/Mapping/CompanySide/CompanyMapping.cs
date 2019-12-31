using KariyerNET.Model.CompanySide;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete.Mapping.CompanySide
{
	public class CompanyMapping:EntityTypeConfiguration<Company>
	{
		public CompanyMapping()
		{
			//Property(p => p.UserName).HasMaxLength(50).IsRequired();
			Property(p => p.Password).HasMaxLength(16).IsRequired();
			Property(p => p.CompanyName).HasMaxLength(100).IsRequired();
			//Property(p => p.LogoURL).HasMaxLength(16).IsRequired();
			Property(p => p.Address).HasMaxLength(400).IsRequired();
			Property(p => p.Phone).HasMaxLength(11).IsRequired();
			Property(p => p.EMail).IsRequired();


		}
	}
}
