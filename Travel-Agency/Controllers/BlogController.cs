using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Travel_Agency.Models;

namespace Travel_Agency.Controllers
{
	public class BlogController : Controller
	{
		Context c = new Context();	
		public IActionResult Index()
		{
			var blogs = c.blogs.ToList();
			ViewBag.Blogs = blogs;
			var values = c.blogs.ToList();
			return View(values);
		}

		public IActionResult Details(int id)
		{
			var comment = c.comments.Include(x => x.Blog).Where(x => x.Blog.Id == id).ToList();
			ViewBag.Comments = comment;
			var value = c.blogs.Find(id);
			return View(value);
		}

		[HttpGet]
		public PartialViewResult AddComment(Blog blog)
		{
			var value = c.blogs.Where(x => x.Id == blog.Id).FirstOrDefault();
			return PartialView(value);
		}

		[HttpPost]
		public IActionResult AddComment(Comment comment)
		{
			//Debug.WriteLine($"BlogId: {comment.Blog.Id} {comment.Username}" );
			c.comments.Add(comment);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
