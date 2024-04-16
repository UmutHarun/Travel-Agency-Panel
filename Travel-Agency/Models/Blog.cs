using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Travel_Agency.Models
{
	public class Blog
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime Date { get; set; }
		public string Description { get; set; }
		public string BlogImageUrl { get; set; }
		public List<Comment> Comments { get; set; }
	}
}
