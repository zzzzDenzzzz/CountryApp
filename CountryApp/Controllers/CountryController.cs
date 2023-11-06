using CountryApp.Contexts;
using CountryApp.Helpers;
using CountryApp.Models;
using CountryApp.ViewModels;
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
            var categories = countryDbContext.Categories;
            var model = new IndexViewModel() { Categories = categories, Countries = countries };

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.categories = new SelectList(countryDbContext.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Country country, IFormFile image)
        {
            try
            {
                country.ImageUrl = await FileUploadHelper.UploadAsync(image);
            }
            catch (InvalidOperationException ex)
            {
                return RedirectToAction("Index", "Error", new { error = ex.Message });
            }
            
            TempData["Status"] = "New Country added";
            await countryDbContext.Countries.AddAsync(country);
            await countryDbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
