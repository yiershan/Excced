using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Exceed.Authorization.Roles;
using Exceed.Authorization.Users;
using Exceed.MultiTenancy;

namespace Exceed.EntityFrameworkCore
{
    public class ExceedDbContext : AbpZeroDbContext<Tenant, Role, User, ExceedDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ExceedDbContext(DbContextOptions<ExceedDbContext> options)
            : base(options)
        {
        }
    }
}
