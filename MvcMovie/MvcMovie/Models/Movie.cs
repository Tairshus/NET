using System;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Tittle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string genre { get; set; }
        public decimal price { get; set; }

    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}