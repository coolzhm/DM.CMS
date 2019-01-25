using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DM.CMS.Configuration;
using DM.CMS.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace DM.CMS.Web.Startup
{
    [DependsOn(
        typeof(CMSApplicationModule), 
        typeof(CMSEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class CMSWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public CMSWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(CMSConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<CMSNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(CMSApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CMSWebModule).GetAssembly());
        }
    }
}