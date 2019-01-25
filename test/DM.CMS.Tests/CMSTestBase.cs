using System;
using System.Threading.Tasks;
using Abp.TestBase;
using DM.CMS.EntityFrameworkCore;
using DM.CMS.Tests.TestDatas;

namespace DM.CMS.Tests
{
    public class CMSTestBase : AbpIntegratedTestBase<CMSTestModule>
    {
        public CMSTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<CMSDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<CMSDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<CMSDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<CMSDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<CMSDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<CMSDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<CMSDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<CMSDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
