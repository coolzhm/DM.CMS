using Microsoft.EntityFrameworkCore;

namespace DM.CMS.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<CMSDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for CMSDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
