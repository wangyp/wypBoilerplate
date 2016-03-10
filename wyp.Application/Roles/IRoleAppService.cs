using System.Threading.Tasks;
using Abp.Application.Services;
using wyp.Roles.Dto;

namespace wyp.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
