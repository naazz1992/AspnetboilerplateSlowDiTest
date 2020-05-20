using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SlowDI.EntityFrameworkCore
{
    public static class SlowDIDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SlowDIDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SlowDIDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
