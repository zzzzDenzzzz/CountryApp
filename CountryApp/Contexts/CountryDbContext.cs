using CountryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryApp.Contexts
{
    public class CountryDbContext : DbContext
    {
        public CountryDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
    }
}
