using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Travel_Agency.Models;

namespace Travel_Agency.Controllers
{
	public class AdminController : Controller
	{
		Context c = new Context();

		//[Authorize]
		public IActionResult Index()
		{
			var values = c.blogs.ToList();
			return View(values);
		}

		//[Authorize]
		[HttpGet]
		public IActionResult NewBlog()
		{
			var values = c.blogs.ToList();
			return View(values);
		}

		//[Authorize]
		[HttpPost]
        public IActionResult NewBlog(Blog blog)
        {
            c.blogs.Add(blog);
			c.SaveChanges();
            return RedirectToAction("Index");
        }

		//[Authorize]
		public IActionResult DeleteBlog(int id)
		{
			var b = c.blogs.Find(id);
			c.blogs.Remove(b);
			c.SaveChanges();
			return RedirectToAction("Index");
		}

		//[Authorize]
		[HttpGet]
		public IActionResult EditBlog(int id) 
		{
			var value = c.blogs.Find(id);
			return View(value);
		}

		//[Authorize]
		[HttpPost]
		public IActionResult EditBlog(Blog blog)
		{
			c.blogs.Update(blog);
			c.SaveChanges();
			return RedirectToAction("Index");	
		}
    }
}
