using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages.Student1
{
    public class DeleteModel : PageModel
    {
		private readonly StudentDbContext db;

		public DeleteModel(StudentDbContext db)
		{
			this.db = db;
		}

		[BindProperty]
		public Student Student { get; set; }

		public void OnGet(int id)
		{
			Student = db.Student.Where(x => x.StudentId == id).FirstOrDefault();
		}

		public IActionResult OnPost()
		{
			if (Student != null)
			{
                
				db.Remove(Student);
				db.SaveChanges();
				return RedirectToPage("./Content");
			}
			else
			{
				return RedirectToPage("./Update");
			}
		}
	}
}

