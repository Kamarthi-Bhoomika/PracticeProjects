using System.ComponentModel.DataAnnotations;

namespace RainbowSchool.Models
{
    public class Marks
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public double SubjectMarks { get; set; }
    }
}
