using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace StudentDetails.Model
{
	public class Student
	{
		[Key]
		public int StudentId { get; set; }

		[Column(TypeName = "VARCHAR(50)")]
		public string Name { get; set; }

		[Column(TypeName = "VARCHAR(255)")]
		public string Email { get; set; }

		public long PhoneNo { get; set; }

	}
}
