using ASP.NET_HW2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET_HW2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // ViewResult
        public IActionResult Index()
        {
            return View();
        }

        // RedirectResult 1
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }

        // RedirectToAction
        public IActionResult RedirectAction()
        {
            return Redirect("/Home/Content");
        }

        // ContentResult
        public IActionResult Content()
        {
            return Content("Hello, World");
        }

        // EmptyResult
        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        // JsonResult
        public IActionResult JsonHuman()
        {
            var json = new Human() { Age = 18, Name = "Isa" };
            return Json(json);
        }

        // PartialView
        public IActionResult Partial()
        {
            // Return Views/Shared/_ValidationScriptsPartial.cshtml (layout)
            return PartialView("_ValidationScriptsPartial");
        }

        // FileView
        public IActionResult File()
        {
            // Return Views/Shared/_ValidationScriptsPartial.cshtml (layout)
            return File("./css/site.css", "text/css");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}