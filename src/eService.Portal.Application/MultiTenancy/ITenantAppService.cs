using Abp.Application.Services;
using eService.Portal.MultiTenancy.Dto;

namespace eService.Portal.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

