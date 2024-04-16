using System.ComponentModel.DataAnnotations;

namespace Travel_Agency.Models
{
	public class About
	{
		[Key]
		public int Id { get; set; }
		public string ImageUrl { get; set; }
		public string Description { get; set; }
	}
}
