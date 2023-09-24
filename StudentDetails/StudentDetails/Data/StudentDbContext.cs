using Microsoft.EntityFrameworkCore;
using StudentDetails.Model;

namespace StudentDetails.Data
{
	public class StudentDbContext : DbContext
	{
		public StudentDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Student> Student { get;  set; }

		public DbSet<StudentTask> StudentTask { get; set; }

		public DbSet<StudentUserTask> StudentUserTask { get; set; }
	}
}
