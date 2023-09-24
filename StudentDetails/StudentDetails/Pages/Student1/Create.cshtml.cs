using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages
{
    public class CreateModel : PageModel
    {
		private readonly StudentDbContext dbContext;

		public CreateModel(StudentDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		[BindProperty]
		public Student StudentRequest { get; set; }

		//public void OnGet()
  //      {
  //      }

		public void OnPost()
		{
			var std = new Student()
			{
				Name = StudentRequest.Name,
				Email = StudentRequest.Email,
				PhoneNo = StudentRequest.PhoneNo,
			};

			dbContext.Student.Add(StudentRequest);
			dbContext.SaveChanges();

			ViewData["Message"] = "Student created successfully!";
		}
    }
}
