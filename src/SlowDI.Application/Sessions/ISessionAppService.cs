using System.Threading.Tasks;
using Abp.Application.Services;
using SlowDI.Sessions.Dto;

namespace SlowDI.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
