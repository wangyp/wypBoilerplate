using System.Threading.Tasks;
using Abp.Application.Services;
using wyp.Users.Dto;

namespace wyp.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}