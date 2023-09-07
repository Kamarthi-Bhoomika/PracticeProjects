using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchool.Models;

namespace RainbowSchool.Data
{
    public class RainbowSchoolContext : DbContext
    {
        public RainbowSchoolContext (DbContextOptions<RainbowSchoolContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchool.Models.Student> Student { get; set; } = default!;

        public DbSet<RainbowSchool.Models.Subject>? Subject { get; set; }

        public DbSet<RainbowSchool.Models.Marks>? Marks { get; set; }
    }
}
