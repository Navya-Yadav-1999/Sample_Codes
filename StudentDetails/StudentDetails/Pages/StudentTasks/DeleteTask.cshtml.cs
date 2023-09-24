using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages.StudentTasks
{
	public class DeleteTaskModel : PageModel
	{
		private readonly StudentDbContext db;

		public DeleteTaskModel(StudentDbContext db)
		{
			this.db = db;
		}
		[BindProperty]
		public StudentTask StudentTask { get; set; }

		public void OnGet(int id)
		{
			StudentTask = db.StudentTask.Where(x => x.ProjectId == id).FirstOrDefault();
		}

		public IActionResult OnPost()
		{
			if (StudentTask != null)
			{

				db.Remove(StudentTask);
				db.SaveChanges();
				return RedirectToPage("./ContentTask");
			}
			else
			{
				return RedirectToPage("./Update");
			}

		}
	}
}
