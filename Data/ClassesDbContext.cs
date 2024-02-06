using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolDatabase.Models;

namespace SchoolDatabase.Data
{
    public class ClassesDbContext : DbContext
    {
        public ClassesDbContext (DbContextOptions<ClassesDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolDatabase.Models.Classes> Classes { get; set; } = default!;
    }
}
