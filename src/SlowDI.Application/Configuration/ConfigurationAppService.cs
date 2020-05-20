using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SlowDI.Configuration.Dto;

namespace SlowDI.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SlowDIAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
