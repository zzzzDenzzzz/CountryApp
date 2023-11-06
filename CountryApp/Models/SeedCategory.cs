using CountryApp.Contexts;

namespace CountryApp.Models
{
    public static class SeedCategory
    {
        public static void Seed(IApplicationBuilder app)
        {
            var result = app.ApplicationServices.CreateScope();
            var context = result.ServiceProvider.GetRequiredService<CountryDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.Add(new Category() { Name = "Adventure" });
                context.Categories.Add(new Category() { Name = "Excursion" });
                context.Categories.Add(new Category() { Name = "Beach" });
                context.Categories.Add(new Category() { Name = "Cultural heritage" });
                context.Categories.Add(new Category() { Name = "Adventurism" });
                context.Categories.Add(new Category() { Name = "Gastronomic tourism" });
                context.Categories.Add(new Category() { Name = "Exotic" });

                context.SaveChanges();
            }
        }
    }
}
