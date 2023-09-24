using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Details_Task.Data;
using Student_Details_Task.Model.Domain;
using Student_Details_Task.Model.View;

namespace Student_Details_Task.Pages.Students1
{
	public class CreateModel : PageModel
	{
		public readonly StudentDbContext dbContext;
		
		public CreateModel(StudentDbContext dbContext)
		{
			dbContext = dbContext;
		}


		[BindProperty]
		public Studentdetail CreateStudentRequest { get; set; } = default!;

		//public void OnGet()
		//      {
		//      }

		public void OnPost()
		{
			var std = new Studentdetail()
			{
				//StudentId = CreateStudentRequest.StudentId,
				Name = CreateStudentRequest.Name,
				Email = CreateStudentRequest.Email,
				PhoneNo = CreateStudentRequest.PhoneNo,
			};

			dbContext.Studentdetails.Add(CreateStudentRequest);
			dbContext.SaveChanges();

			ViewData["Message"] = "Student created successfully!";

		}
	}
}
