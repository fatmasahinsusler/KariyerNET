using KariyerNET.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete.Mapping
{
	public class TownMapping:EntityTypeConfiguration<Town>
	{
		public TownMapping()
		{
			//HasRequired(a => a.City).WithMany(a => a.Towns).HasForeignKey(a => a.CityID);
			





		}
	}
}
