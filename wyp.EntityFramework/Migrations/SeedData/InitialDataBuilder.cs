using wyp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace wyp.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly wypDbContext _context;

        public InitialDataBuilder(wypDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
