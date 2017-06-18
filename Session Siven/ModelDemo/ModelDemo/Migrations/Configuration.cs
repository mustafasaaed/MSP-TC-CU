namespace ModelDemo.Migrations
{
    using ModelDemo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelDemo.Models.ModelDemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ModelDemo.Models.ModelDemoContext";
        }

        protected override void Seed(ModelDemo.Models.ModelDemoContext context)
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

            context.Genres.AddOrUpdate(new Genre { Name = "Jazz" });
            context.Genres.AddOrUpdate(new Genre { Name = "Pop" });
            context.Artists.AddOrUpdate(new Artist { Name = "Adele" });
            context.Albums.AddOrUpdate(new Album
            {
                Artist = new Artist { Name = "Hugh Laurie" },
                Genre = new Genre { Name = "Blues"},
                Price = 9.99m,
                Title= "Didn't it rain"
            });

        }
    }
}
