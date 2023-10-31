using System.ComponentModel.DataAnnotations;

namespace CountryApp.Models
{
    public class Language
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Country> Country { get; set; }
    }
}
