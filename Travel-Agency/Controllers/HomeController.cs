using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Travel_Agency.Models;

namespace Travel_Agency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();  

        public IActionResult Index()
        {
            var BlogValues = c.blogs.ToList();
            return View(BlogValues);
        }

        public PartialViewResult HomeBlogPartial()
        {
            var values = c.blogs.OrderByDescending(b => b.Id).Take(3).ToList();
            return PartialView(values);
        }
    }
}