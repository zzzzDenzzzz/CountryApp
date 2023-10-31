﻿using CountryApp.Constants;
using System.ComponentModel.DataAnnotations;

namespace CountryApp.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name field is empty"), MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Area field is empty")]
        public decimal Area { get; set; }

        [Required(ErrorMessage = "Population field is empty")]
        public decimal Population { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Image url field is empty"), Display(Name = "Image url")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Parts of the World field is empty"), Display(Name = "Parts of the World")]
        public PartsOfTheWorld PartsOfTheWorld { get; set; }

        public ICollection<Language> Languages { get; set; }
    }
}
