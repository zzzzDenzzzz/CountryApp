using CountryApp.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace CountryApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly CountryDbContext countryDbContext;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}