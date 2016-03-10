using Abp.Authorization.Roles;
using wyp.MultiTenancy;
using wyp.Users;

namespace wyp.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}