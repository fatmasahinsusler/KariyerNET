using KariyerNET.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete
{
	public class MyStrategy : DropCreateDatabaseAlways<KariyerNETDBContext>
	{
		protected override void Seed(KariyerNETDBContext context)
		{
			context.Companies.Add(new Model.CompanySide.Company()
			{
				EMail = "askoyazilim@mail.com",
				Password = "123",
				CompanyName = "Aşko Yazılım",
				Address = "Çengelköy",
				LogoURL = "kdfjkd",
				Phone = "5476876758"
			});
			context.Cities.Add(new City()
			{
				CityName="İstanbul"		
			});
			context.Cities.Add(new City()
			{
				CityName = "Trabzon"
			});
			context.Cities.Add(new City()
			{
				CityName = "Gaziantep"
			});
			context.Towns.Add(new Town()
			{
				TownName="Üsküdar"
			});
			context.Towns.Add(new Town()
			{
				TownName = "Ümraniye"
			});
			context.Towns.Add(new Town()
			{
				TownName = "Şirinevler"
			});
			context.Perfections.Add(new Model.EmployeeSide.Perfection()
			{
				PerfectionName="c#"
			});
			context.Perfections.Add(new Model.EmployeeSide.Perfection()
			{
				PerfectionName = "Javascript"
			});
			context.Perfections.Add(new Model.EmployeeSide.Perfection()
			{
				PerfectionName = "Jquery"
			});
			context.SaveChanges();
		}
	}
}
