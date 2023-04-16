using System.Threading.Tasks;
using Abp.Application.Services;
using eService.Portal.Sessions.Dto;

namespace eService.Portal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
