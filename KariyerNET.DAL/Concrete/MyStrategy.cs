using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete
{
	public class MyStrategy:DropCreateDatabaseAlways<KariyerNETDBContext>
	{
		protected override void Seed(KariyerNETDBContext context)
		{
			
		}
	}
}
