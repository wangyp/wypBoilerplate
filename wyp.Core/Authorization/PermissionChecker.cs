using Abp.Authorization;
using wyp.Authorization.Roles;
using wyp.MultiTenancy;
using wyp.Users;

namespace wyp.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
