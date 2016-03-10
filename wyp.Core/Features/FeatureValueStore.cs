using Abp.Application.Features;
using wyp.Authorization.Roles;
using wyp.MultiTenancy;
using wyp.Users;

namespace wyp.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}