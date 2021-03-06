﻿using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using wyp.Authorization.Roles;
using wyp.Editions;
using wyp.Users;

namespace wyp.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}