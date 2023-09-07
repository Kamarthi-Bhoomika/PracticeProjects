using System.ComponentModel.DataAnnotations;

namespace RainbowSchool.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
    }
}
