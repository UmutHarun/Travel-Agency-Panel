using System.ComponentModel.DataAnnotations;

namespace Travel_Agency.Models
{
	public class Address
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string AddressI { get; set; }	
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Location { get; set; }
	}
}
