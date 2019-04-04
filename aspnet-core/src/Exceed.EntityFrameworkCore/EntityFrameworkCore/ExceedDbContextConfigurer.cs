using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Exceed.EntityFrameworkCore
{
    public static class ExceedDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ExceedDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ExceedDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
