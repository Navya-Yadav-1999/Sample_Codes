using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDetails.Model
{
	public class StudentUserTask
	{
		public StudentUserTask()
		{
			 Assigned = true;
			 deasigned = false;

			
		}
                                        
		[Key]
		public int Id { get; set; }

        [Required]
        public  int StudentId { get; set; }

        [Required]
        public  int ProjectId { get; set; }

		[Required]
		public bool Assigned { get; set; }

		[Required]
		public bool deasigned { get; set; }
		[ForeignKey("StudentId")]

		public virtual Student Student { get; set; }
        [ForeignKey("ProjectId")]

        public virtual StudentTask StudentTask { get; set; }


    }
}
