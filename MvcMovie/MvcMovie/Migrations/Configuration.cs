namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Cazafantasmas",
                    ReleaseDate = DateTime.Parse("11-1-1989"),
                    genre = "Comedia",
                    rating = "PG",
                    price = 8.99M
                },
                new Movie
                {
                    Title = "Algo",
                    ReleaseDate = DateTime.Parse("21-03-2007"),
                    genre = "Suspenso",
                    rating = "PG",
                    price = 24.97M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("15-4-1959"),
                    genre = "Vaqueros",
                    rating = "PG",
                    price = 3.99M
                }
            );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
