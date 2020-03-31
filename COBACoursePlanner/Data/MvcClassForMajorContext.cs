using COBACoursePlanner.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COBACoursePlanner.Data
{
    public class MvcClassForMajorContext : DbContext
    {
        public MvcClassForMajorContext (DbContextOptions<MvcClassForMajorContext> options)
            : base(options)
        {
        }

        public DbSet<ClassForMajor> ClassForMajor { get; set; }

        public DbSet<Major> Major { get; set; }
    }
}
