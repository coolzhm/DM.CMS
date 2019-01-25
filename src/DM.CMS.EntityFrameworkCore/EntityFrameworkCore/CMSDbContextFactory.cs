using DM.CMS.Configuration;
using DM.CMS.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DM.CMS.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class CMSDbContextFactory : IDesignTimeDbContextFactory<CMSDbContext>
    {
        public CMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(CMSConsts.ConnectionStringName)
            );

            return new CMSDbContext(builder.Options);
        }
    }
}