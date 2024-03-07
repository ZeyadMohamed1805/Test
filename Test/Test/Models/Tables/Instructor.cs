using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Test.Models.Tables
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        [Required]
        public String InstructorFirstName { get; set; }
        public String InstructorLastName { get; set; } ///
        public int InstructorAge { get; set; }
        public int InstructorSalary { get; set; }
        public String InstructorAddress { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public String InstructorEmail { get; set; }
        [ForeignKey("InstructorEmail")]
        public User User { get; set; }
    }
}
