using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Model;

public class StudentUserTaskViewModel
{
	[Required]
	public int StudentId { get; set; }

	[Required]
	public int ProjectId { get; set; }
}
