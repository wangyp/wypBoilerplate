using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using wyp.MultiTenancy.Dto;

namespace wyp.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
