using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages.Student1
{
    public class UpdateModel : PageModel
    {
		private readonly StudentDbContext db;
		public UpdateModel(StudentDbContext db)
		{
			this.db = db;
		}

		[BindProperty]
		public Student Student { get; set; }
		
        public void OnGet(int id)
        {
			 Student = db.Student.Where(x =>x.StudentId== id).FirstOrDefault();
       
		}

		public IActionResult OnPost()
		{
			if (Student != null)
			{
				
				var student = db.Student.Where(x => x.StudentId == Student.StudentId).FirstOrDefault();
				student.Name = Student.Name;
				student.Email = Student.Email;
				student.PhoneNo = Student.PhoneNo;
				db.Student.Update(student);
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
	

