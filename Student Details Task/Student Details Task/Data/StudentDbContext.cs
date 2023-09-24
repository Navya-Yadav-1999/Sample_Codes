using Microsoft.EntityFrameworkCore;
using Student_Details_Task.Model.Domain;

namespace Student_Details_Task.Data
{
    public class StudentDbContext : DbContext
	{
		public StudentDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Studentdetail> Studentdetails { get; set; }
		

		
	}
}
 