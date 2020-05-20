using System.Threading.Tasks;
using SlowDI.Configuration.Dto;

namespace SlowDI.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
