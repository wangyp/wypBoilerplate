using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace wyp.EntityFramework.Repositories
{
    public abstract class wypRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<wypDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected wypRepositoryBase(IDbContextProvider<wypDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class wypRepositoryBase<TEntity> : wypRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected wypRepositoryBase(IDbContextProvider<wypDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
