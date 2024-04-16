using Microsoft.AspNetCore.Mvc;
using Travel_Agency.Models;

namespace Travel_Agency.Controllers
{
	public class AboutController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{
			var values = c.abouts.ToList();
			return View(values);
		}
	}
}
