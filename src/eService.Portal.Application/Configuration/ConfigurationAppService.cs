using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using eService.Portal.Configuration.Dto;

namespace eService.Portal.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PortalAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
