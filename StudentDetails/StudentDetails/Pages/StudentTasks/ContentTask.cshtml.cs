using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages.StudentTasks
{
    public class ContentModel : PageModel
    {
		private readonly StudentDbContext db;
		

		public List<StudentTask> StudentTask { get; set; }

		[BindProperty(SupportsGet = true)]
		public string SearchTerm { get; set; }
		public ContentModel(StudentDbContext db)
		{
			this.db = db;
		}

		public void OnGet()
        {
			var tasks = from m in db.StudentTask select m;

			if (!string.IsNullOrEmpty(SearchTerm))
			{
				tasks = tasks.Where( s => s.ProjectName.Contains(SearchTerm));
				StudentTask = tasks.ToList();
			}
			else
			{
				StudentTask = db.StudentTask.ToList();
			}

		}
	}
}
