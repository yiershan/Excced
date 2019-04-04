using System.Threading.Tasks;
using Exceed.Configuration.Dto;

namespace Exceed.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
