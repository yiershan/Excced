using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Exceed.Configuration;
using Exceed.Web;

namespace Exceed.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ExceedDbContextFactory : IDesignTimeDbContextFactory<ExceedDbContext>
    {
        public ExceedDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ExceedDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ExceedDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ExceedConsts.ConnectionStringName));

            return new ExceedDbContext(builder.Options);
        }
    }
}
