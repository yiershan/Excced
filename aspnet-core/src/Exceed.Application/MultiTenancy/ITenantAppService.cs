using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Exceed.MultiTenancy.Dto;

namespace Exceed.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

