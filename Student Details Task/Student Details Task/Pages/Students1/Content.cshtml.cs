using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Details_Task.Data;
using Student_Details_Task.Model.Domain;

namespace Student_Details_Task.Pages.Students1
{
	public class ContentModel : PageModel
	{
		private readonly StudentDbContext _db;
		public List<Studentdetail> Studentdetails { get; set; }
		public ContentModel(StudentDbContext db)
		{
			_db = db;
		}

		public void OnGet()
		
		{
			Studentdetails = _db.Studentdetails.ToList();
		}
	}
}