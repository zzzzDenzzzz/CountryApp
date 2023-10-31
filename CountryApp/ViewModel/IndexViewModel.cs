using CountryApp.Models;

namespace CountryApp.ViewModel
{
    public class IndexViewModel
    {
        public ICollection<Country> Countries { get; set; }

        public ICollection<Language> Languages { get; set; }
    }
}
