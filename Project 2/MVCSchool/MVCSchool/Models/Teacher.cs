using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSchool.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}