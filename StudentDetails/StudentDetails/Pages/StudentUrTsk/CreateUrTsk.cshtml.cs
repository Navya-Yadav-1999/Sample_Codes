using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using StudentDetails.Data;
using StudentDetails.Model;

namespace StudentDetails.Pages.StudentUrTsk
{
    public class CreateUrTskModel : PageModel
    {
        private StudentDbContext _context;

        public CreateUrTskModel(StudentDbContext dbcontext)
        {
            _context = dbcontext;
        }
        [BindProperty]
        public StudentUserTaskViewModel StudentRequest { get; set; }
        public IActionResult OnGet()
        {
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "Name");
            ViewData["ProjectId"] = new SelectList(_context.StudentTask, "ProjectId", "ProjectName");
            return Page();
        }

        public IActionResult OnPost()
		{
			
				var sut = new StudentUserTask()
				{
					StudentId = StudentRequest.StudentId,
					ProjectId = StudentRequest.ProjectId,
					Assigned = true
				};
				_context.StudentUserTask.Add(sut);
				_context.SaveChanges();
				return RedirectToPage("./ViewUrTsk");
			}
		//else
		//{
		public void delete()
		{


			var stu = new StudentUserTask()
			{
				StudentId = StudentRequest.StudentId,
				ProjectId = StudentRequest.ProjectId,
				deasigned = false
			};
			_context.StudentUserTask.Update(stu);
			_context.SaveChanges();
			 RedirectToPage("./viewurtsk");
		}

			
    }
}

    
