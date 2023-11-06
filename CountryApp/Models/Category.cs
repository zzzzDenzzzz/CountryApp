namespace CountryApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Country> Countries { get; set; }
    }
}
