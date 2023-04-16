using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using eService.Portal.MultiTenancy;

namespace eService.Portal.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
