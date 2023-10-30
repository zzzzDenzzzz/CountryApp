using System.ComponentModel.DataAnnotations;

namespace CountryApp.Constants
{
    public enum PartsOfTheWorld
    {
        [Display(Name = "Asia")]
        ASIA = 1,
        [Display(Name = "Africa")]
        AFRICA,
        [Display(Name = "Europa")]
        EUROPA,
        [Display(Name = "North America")]
        NORTH_AMERICA,
        [Display(Name = "South America")]
        SOUTH_AMERICA,
        [Display(Name = "Australia")]
        AUSTRALIA,
    }
}
