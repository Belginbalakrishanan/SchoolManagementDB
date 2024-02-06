using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolDatabase.Models;

namespace SchoolDatabase.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext (DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolDatabase.Models.Student> Student { get; set; } = default!;
    }
}
