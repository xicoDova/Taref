namespace Taref.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Taref.Data.DataContexts.dbTAREF>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Taref.Data.DataContexts.dbTAREF";
        }

        protected override void Seed(Taref.Data.DataContexts.dbTAREF context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}