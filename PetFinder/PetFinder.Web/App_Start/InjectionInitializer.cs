using PetFinder.Application.ApplicationService;
using PetFinder.Data;
using PetFinder.Data.Context;
using PetFinder.Data.Interfaces;
using PetFinder.Data.Repository;
using PetFinder.Domain.Interfaces.Repository;
using PetFinder.Domain.Interfaces.Services;
using PetFinder.Domain.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace PetFinder.Web.App_Start
{
    public static class InjectionInitializer
    {
        public static object GlobalConfiguration { get; private set; }

        public static Container Initialize()
        {
            var container = new Container();
            container.Options.DefaultLifestyle = Lifestyle.Scoped;
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            // container.RegisterSingleton<IAppBuilder>(app);

            container.Register<IDbContext, PetFinderContext>();
            container.Register<IUnitOfWork, UnitOfWork>();
            container.Register<PetFinderContext>();
            /*  container.Register<ApplicationUserManager>();

              //container.Register<ApplicationDbContext>(() => new ApplicationDbContext("Your constring goes here"),
              //    Lifestyle.Scoped);

              container.Register<IUserStore<ApplicationUser>>(
                  () => new UserStore<ApplicationUser>(
                      container.GetInstance<PetFinderContext>()),
                  Lifestyle.Scoped);

              container.RegisterInitializer<ApplicationUserManager>(
                  manager => InitializeUserManager(manager, app));


              container.Register<ApplicationSignInManager>();
              container.Register<ApplicationUserManager>();*/

            //container.Register<PetFinderContext>();


            container.Register<RacaAppService>();
            container.Register<IRacaService, RacaService>();
            container.Register<IRacaRepository, RacaRepository>();

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

            return container;
        }


        /*  private static void InitializeUserManager(ApplicationUserManager manager, IAppBuilder app)
          {
              manager.UserValidator = new UserValidator<ApplicationUser>(manager)
              {
                  AllowOnlyAlphanumericUserNames = false,
                  RequireUniqueEmail = true
              };

              //Configure validation logic for passwords
              manager.PasswordValidator = new PasswordValidator()
              {
                  RequiredLength = 6,
                  RequireNonLetterOrDigit = false,
                  RequireDigit = true,
                  RequireLowercase = true,
                  RequireUppercase = true,
              };

              var dataProtectionProvider = app.GetDataProtectionProvider();

              if (dataProtectionProvider != null)
              {
                  manager.UserTokenProvider =
                      new DataProtectorTokenProvider<ApplicationUser>(
                          dataProtectionProvider.Create("ASP.NET Identity"));
              }
          }*/
    }
}