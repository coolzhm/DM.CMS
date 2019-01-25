using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DM.CMS.Web.Startup;
namespace DM.CMS.Web.Tests
{
    [DependsOn(
        typeof(CMSWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class CMSWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CMSWebTestModule).GetAssembly());
        }
    }
}