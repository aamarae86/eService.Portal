using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using eService.Portal.Authorization.Roles;
using eService.Portal.Authorization.Users;
using eService.Portal.MultiTenancy;

namespace eService.Portal.EntityFrameworkCore
{
    public class PortalDbContext : AbpZeroDbContext<Tenant, Role, User, PortalDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PortalDbContext(DbContextOptions<PortalDbContext> options)
            : base(options)
        {
        }
    }
}
