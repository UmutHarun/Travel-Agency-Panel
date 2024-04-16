using Microsoft.AspNetCore.Mvc;

namespace Travel_Agency.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
