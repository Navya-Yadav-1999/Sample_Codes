using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Details_Task.Model.Domain
{
    
    public class Studentdetail
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
