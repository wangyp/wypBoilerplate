using System.Data.Entity.Migrations;
using wyp.Migrations.SeedData;

namespace wyp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<wyp.EntityFramework.wypDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "wyp";
        }

        protected override void Seed(wyp.EntityFramework.wypDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
