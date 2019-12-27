using KariyerNET.DAL.Abstract;
using KariyerNET.DAL.Abstract.Firma;
using KariyerNET.DAL.Abstract.Employee;
using KariyerNET.DAL.Concrete;
using KariyerNET.DAL.Concrete.Firma;
using KariyerNET.DAL.Concrete.Employee;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Ninject
{
	public class CustomDALModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ICompanyDAL>().To<CompanyRepository>();
			Bind<IJobAdvertDAL>().To<JobAdvertRepository>();
			Bind<ISectorDAL>().To<SectorRepository>();
			Bind<ICertificateDAL>().To<CertificateRepository>();
			Bind<IEducationDAL>().To<EducationRepository>();
			Bind<IExamDAL>().To<ExamRepository>();
			Bind<IExamInfoDAL>().To<ExamInfoRepository>();
			Bind<IExperienceDAL>().To<ExperienceRepository>();
			Bind<IHobbieDAL>().To<HobbieRepository>();
			Bind<ILanguageDAL>().To<LanguageRepository>();
			Bind<ILoginDAL>().To<LoginRepository>();
			Bind<IPerfectionDAL>().To<PerfectionRepository>();
			Bind<IReferencesDAL>().To<ReferencesRepository>();
			Bind<IResumeDAL>().To<ResumeRepository>();
			Bind<ICityDAL>().To<CityRepository>();
			Bind<ITownDAL>().To<TownRepository>();
		}
	}
}
