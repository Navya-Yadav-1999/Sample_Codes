using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages.Student1
{
    public class ContentModel : PageModel
    {
		private readonly StudentDbContext db;

		public List<Student> Student { get; set; }

		public ContentModel(StudentDbContext db)
		{
			this.db = db;
		}
		
		public void OnGet()
        {
			Student = db.Student.ToList();
        }
    }
}
