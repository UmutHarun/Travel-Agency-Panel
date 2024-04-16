using System.ComponentModel.DataAnnotations;

namespace Travel_Agency.Models
{
	public class Comment
	{
		[Key]
		public int Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string CommentI { get; set; }
		public int BlogId { get; set; }
		public Blog Blog { get; set; }
	}
}
