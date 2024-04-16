using System.ComponentModel.DataAnnotations;

namespace Travel_Agency.Models
{
	public class Contact
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Topic { get; set; }
		public string Message { get; set; }
	}
}
