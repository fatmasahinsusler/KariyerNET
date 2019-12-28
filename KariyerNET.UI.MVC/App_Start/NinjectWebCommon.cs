[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(KariyerNET.UI.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(KariyerNET.UI.MVC.App_Start.NinjectWebCommon), "Stop")]


namespace KariyerNET.UI.MVC.App_Start
{
    using System;
    using System.Web;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using KariyerNET.BLL.Abstract;
    using KariyerNET.BLL.Concrete;
    using KariyerNET.BLL.Ninject;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using KariyerNET.BLL.Abstract.CompanySide;
    using KariyerNET.BLL.Concrete.CompanySide;
    using KariyerNET.BLL.Abstract.EmployeeSide;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ICompanyService>().To<CompanyService>();
            kernel.Bind<IJobAdvertService>().To<JobAdvertService>();
            kernel.Bind<ISectorService>().To<SectorService>();
            kernel.Bind<ICertificateService>().To<CertificateService>();
            kernel.Bind<IEducationService>().To<EducationService>();
            kernel.Bind<IExamInfoService>().To<ExamInfoService>();
            kernel.Bind<IExamService>().To<ExamService>();
            kernel.Bind<IExperienceService>().To<ExperienceService>();
            kernel.Bind<IHobbieService>().To<HobbieService>();
            kernel.Bind<ILanguageService>().To<LanguageService>();
            kernel.Bind<ILoginService>().To<LoginService>();
            kernel.Bind<IPerfectionService>().To<PerfectionService>();
            kernel.Bind<IReferencesService>().To<ReferencesService>();
            kernel.Bind<IResumeService>().To<ResumeService>();
            kernel.Bind<ICityService>().To<CityService>();
            kernel.Bind<ITownService>().To<TownService>();
            kernel.Load<CustomDALModule>();
        }
    }
}