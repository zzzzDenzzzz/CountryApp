using Microsoft.AspNetCore.Mvc;

namespace CountryApp.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(string error)
        {
            ViewBag.Error = error;
            return View();
        }
    }
}
