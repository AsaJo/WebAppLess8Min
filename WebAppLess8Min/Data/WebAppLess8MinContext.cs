using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppLess8Min.Models;

namespace WebAppLess8Min.Data
{
    public class WebAppLess8MinContext : DbContext
    {
        public WebAppLess8MinContext (DbContextOptions<WebAppLess8MinContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppLess8Min.Models.Student> Student { get; set; } = default!;

        public DbSet<WebAppLess8Min.Models.Course> Course { get; set; }
    }
}
