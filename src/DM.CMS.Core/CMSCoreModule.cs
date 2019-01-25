using Abp.Modules;
using Abp.Reflection.Extensions;
using DM.CMS.Localization;

namespace DM.CMS
{
    public class CMSCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            CMSLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CMSCoreModule).GetAssembly());
        }
    }
}