using System.ComponentModel.DataAnnotations;

namespace RainbowSchool.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }
    }
}
