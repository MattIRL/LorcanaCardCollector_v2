using System.Diagnostics;
using LorcanaCardCollector.Models;
using Microsoft.AspNetCore.Mvc;

namespace LorcanaCardCollector.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        // Search button logic for displaying error or calling card images
        public IActionResult Index(LorcanaCardCollectorModel model)
        {
            if (ModelState.IsValid)
            {
                string imgUrl = Url.Content($"{model.FetchCard()}");
                ViewBag.Results = $"<img src='{imgUrl}' alt='Dynamic Lorcana Card Image' class='col-3 mb-4' />";
            }
            else
            {
                ViewBag.Results = "<p class='text-danger pb-4'>Please enter text before searching.</p>";
            }
            return View(model);
        }

    }
}
