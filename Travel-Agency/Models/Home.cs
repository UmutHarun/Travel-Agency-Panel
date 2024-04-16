using System.ComponentModel.DataAnnotations;

namespace Travel_Agency.Models
{
	public class Home
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
