using KariyerNET.DAL.Concrete.Mapping.CompanySide;
using KariyerNET.Model;
using KariyerNET.Model.CompanySide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.DAL.Concrete
{
    public class KariyerNETDBContext : DbContext
    {
       

        public KariyerNETDBContext():base("Server=.;Database=KariyetNetDB;Integrated Security=true")//uid=sa;pwd=123
{
            Database.SetInitializer<KariyerNETDBContext>(new MyStrategy());
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobAdvert> JobAdverts { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamInfo> ExamInfos { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Hobbie> Hobbies { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Perfection> Perfections { get; set; }
        public DbSet<References> References { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Town> Towns { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Configurations.Add(new);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new CompanyMapping());
           
        }

    }
}
