using CountryApp.Contexts;
using CountryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CountryApp.Controllers
{
    public class CountryController : Controller
    {
        private readonly CountryDbContext countryDbContext;

        public CountryController(CountryDbContext countryDbContext)
        {
            this.countryDbContext = countryDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var countries = countryDbContext.Countries;
            return View(countries);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Country country)
        {
            if (ModelState.IsValid)
            {
                TempData["Status"] = "New Country added";
                await countryDbContext.Countries.AddAsync(country);
                await countryDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(country);
        }
    }
}
