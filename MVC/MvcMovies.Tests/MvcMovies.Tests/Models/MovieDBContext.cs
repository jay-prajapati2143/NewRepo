

using System.Data.Entity;

namespace MvcMovies.Tests.Models
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}