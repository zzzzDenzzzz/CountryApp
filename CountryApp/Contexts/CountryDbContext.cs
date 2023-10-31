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

        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(x => x.Languages)
                .WithMany(x => x.Country)
                .UsingEntity<CountryLanguage>();
        }
    }
}
