using System.Threading.Tasks;
using Abp.Application.Services;
using eService.Portal.Authorization.Accounts.Dto;

namespace eService.Portal.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
