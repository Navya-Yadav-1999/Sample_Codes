using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages.StudentUrTsk
{
    public class ViewUrTskModel : PageModel
    {
        private readonly StudentDbContext db;
		

        public ViewUrTskModel(StudentDbContext _db)
        {
            db = _db;
        }
        [BindProperty]
		public List<StudentUserTask> StudentUserTask { get; set; }
		public void OnGet()
        {
            StudentUserTask = db.StudentUserTask.ToList();
        }
    }
}
