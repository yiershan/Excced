using System.Threading.Tasks;
using Abp.Application.Services;
using Exceed.Sessions.Dto;

namespace Exceed.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
