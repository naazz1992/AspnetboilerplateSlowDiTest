using Abp.Application.Services;
using SlowDI.MultiTenancy.Dto;

namespace SlowDI.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

