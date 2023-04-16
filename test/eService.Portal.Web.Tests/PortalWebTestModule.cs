using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using eService.Portal.EntityFrameworkCore;
using eService.Portal.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace eService.Portal.Web.Tests
{
    [DependsOn(
        typeof(PortalWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PortalWebTestModule : AbpModule
    {
        public PortalWebTestModule(PortalEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PortalWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PortalWebMvcModule).Assembly);
        }
    }
}