using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages.StudentTasks
{
    public class CreateModel : PageModel
    {
		private readonly StudentDbContext dbContext;

		public CreateModel(StudentDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		[BindProperty]
		public StudentTask StudentRequest { get; set; }
		//public void OnGet()
		//      {
		//      }

		public void OnPost()
		{
			var std = new StudentTask()
			{
				ProjectName = StudentRequest.ProjectName,
			};

			dbContext.StudentTask.Add(StudentRequest);
			dbContext.SaveChanges();

			ViewData["Message"] = "Student created successfully!";
		}
	}
}
