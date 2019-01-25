using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DM.CMS
{
    [DependsOn(
        typeof(CMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CMSApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CMSApplicationModule).GetAssembly());
        }
    }
}