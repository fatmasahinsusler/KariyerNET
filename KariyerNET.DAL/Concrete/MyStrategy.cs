using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete
{
	public class MyStrategy:DropCreateDatabaseIfModelChanges<KariyerNETDBContext>
	{
		protected override void Seed(KariyerNETDBContext context)
		{
			context.Companies.Add(new Model.CompanySide.Company()
			{
				EMail="aşkoyazilim@mail.com",
				Password="123",
				CompanyName="Aşko Yazılım",
				Address="Çengelköy"
			});

			context.SaveChanges();
		}
	}
}
