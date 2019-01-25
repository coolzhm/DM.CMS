using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DM.CMS.EntityFrameworkCore
{
    public class CMSDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public CMSDbContext(DbContextOptions<CMSDbContext> options) 
            : base(options)
        {

        }
    }
}
