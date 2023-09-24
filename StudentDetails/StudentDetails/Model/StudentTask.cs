using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Model
{
	public class StudentTask
	{
		[Key]
		public int ProjectId { get; set; }

		[Column(TypeName = "VARCHAR(50)")]
		public string ProjectName { get; set; }
	}
}
