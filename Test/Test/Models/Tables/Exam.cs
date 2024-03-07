using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models.Tables
{
    public class Exam
    {
        public int DepartmentID { get; set; }
        [Required]
        public String DepartmentName { get; set; }


        //Supervisor?
        public int DepartmentSP { get; set; }
        [ForeignKey("DepartmentSP")]
        public Instructor Instructor { get; set; }
    }
}
