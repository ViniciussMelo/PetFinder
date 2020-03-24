namespace PetFinder.Data.Migrations
{
    using PetFinder.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetFinder.Data.Context.PetFinderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetFinder.Data.Context.PetFinderContext context)
        {
            context.Pais.AddOrUpdate(a=>a.Sigla, new Pais() { });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
