using CountryApp.Models;

namespace CountryApp.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Country> Countries { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
