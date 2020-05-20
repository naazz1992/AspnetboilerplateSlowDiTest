using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SlowDI.Authorization.Roles;
using SlowDI.Authorization.Users;
using SlowDI.MultiTenancy;
using SlowDI.SlowDis;

namespace SlowDI.EntityFrameworkCore
{
    public class SlowDIDbContext : AbpZeroDbContext<Tenant, Role, User, SlowDIDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<SlowDiEntity> SlowDiEntities { get; set; }
        public SlowDIDbContext(DbContextOptions<SlowDIDbContext> options)
            : base(options)
        {
        }
    }
}
