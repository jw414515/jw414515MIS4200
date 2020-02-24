namespace jw414515MIS4200.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<jw414515MIS4200.DAL.Context2>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "jw414515MIS4200.DAL.Context2";
        }

        protected override void Seed(jw414515MIS4200.DAL.Context2 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
