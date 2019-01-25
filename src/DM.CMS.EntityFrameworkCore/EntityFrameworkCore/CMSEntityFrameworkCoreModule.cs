using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DM.CMS.EntityFrameworkCore
{
    [DependsOn(
        typeof(CMSCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class CMSEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CMSEntityFrameworkCoreModule).GetAssembly());
        }
    }
}