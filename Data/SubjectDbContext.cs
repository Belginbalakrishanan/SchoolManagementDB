using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolDatabase.Models;

namespace SchoolDatabase.Data
{
    public class SubjectDbContext : DbContext
    {
        public SubjectDbContext (DbContextOptions<SubjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolDatabase.Models.Subject> Subject { get; set; } = default!;
    }
}
