using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Details_Task.Data;
using Student_Details_Task.Model.Domain;
using Student_Details_Task.Model.View;

namespace Student_Details_Task.Pages.Students1
{
	public class UpdateModel : PageModel
	{
		private readonly StudentDbContext _db;
		private object dbContext;

		[BindProperty]
		public UpdateStudentView UpdateStudentView { get; set; }
		public UpdateModel(StudentDbContext db)
		{
			_db = db;
		}


		public void OnGet(int id)
		{
			var student = _db.Studentdetails.Where(x =>x.StudentId== id).FirstOrDefault();	

			if (student != null)
			{
				//Convert domain model to view model
				UpdateStudentView = new UpdateStudentView()
				{
					StudentId = student.StudentId,
					Name = student.Name,
					Email = student.Email,
					PhoneNo = student.PhoneNo
				};
			}
		}
	
	    public IActionResult OnPost()
		{
			
			if (UpdateStudentView != null)
			{
				Studentdetail student = new Studentdetail()
				{
					StudentId = UpdateStudentView.StudentId,
					Name = UpdateStudentView.Name,
					Email = UpdateStudentView.Email,
					PhoneNo = UpdateStudentView.PhoneNo
				};
				var std = _db.Studentdetails.Where(x => x.StudentId == student.StudentId).FirstOrDefault();
				std.Name = student.Name;
				std.Email = student.Email;
				std.PhoneNo = student.PhoneNo;
				_db.Studentdetails.Update(std);
				_db.SaveChanges();
				return RedirectToPage("./Content");
			}
			else
			{
				return RedirectToPage("./Update");
			}
		

		}
	}

}
