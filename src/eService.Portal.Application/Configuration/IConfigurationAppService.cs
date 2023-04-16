using System.Threading.Tasks;
using eService.Portal.Configuration.Dto;

namespace eService.Portal.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
