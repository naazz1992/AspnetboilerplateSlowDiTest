using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SlowDI.Configuration;
using SlowDI.Web;

namespace SlowDI.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SlowDIDbContextFactory : IDesignTimeDbContextFactory<SlowDIDbContext>
    {
        public SlowDIDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SlowDIDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SlowDIDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SlowDIConsts.ConnectionStringName));

            return new SlowDIDbContext(builder.Options);
        }
    }
}
