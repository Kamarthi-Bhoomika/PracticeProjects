using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RainbowSchoolStatistics.Models
{
    public class Statistics
    {
        public int StudentCount { get; set; }
        public Student MaximumMarks { get; set; }
        public Student MinimumMarks { get; set; }
        public List<Student> LessThan65Marks { get; set; }
        public double PassedPercentage { get; set; }

    }
}