using System.ComponentModel.DataAnnotations;

namespace CountryApp.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Where Name?"), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Area { get; set; }

        [Required]
        public decimal Population { get; set; }

        public string Description { get; set; }

        [Required, Display(Name = "Image url")]
        public string ImageUrl { get; set; }
    }
}
