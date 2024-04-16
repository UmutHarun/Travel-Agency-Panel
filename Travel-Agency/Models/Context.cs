using Microsoft.EntityFrameworkCore;

namespace Travel_Agency.Models
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("server=DESKTOP-LMK3OGQ; database=TravelAgency; integrated security=true; TrustServerCertificate=True;");
		}

		public DbSet<About> abouts { get; set; }
		public DbSet<Address> addresses { get; set; }
		public DbSet<Admin> admins { get; set; }
		public DbSet<Blog> blogs { get; set; }
		public DbSet<Comment> comments { get; set; }
		public DbSet<Contact> contacts { get; set; }
		public DbSet<Home> homes { get; set; }
	}
}
