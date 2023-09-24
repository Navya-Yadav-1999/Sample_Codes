using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages.StudentTasks
{
    public class UpdateModel : PageModel
    {
		private readonly StudentDbContext db;

		public UpdateModel(StudentDbContext db)
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

				var studentTask = db.StudentTask.Where(x => x.ProjectId == StudentTask.ProjectId).FirstOrDefault();
				studentTask.ProjectName = StudentTask.ProjectName;
				db.StudentTask.Update(studentTask);
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
