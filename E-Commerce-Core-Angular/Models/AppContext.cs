using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Core_Angular.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        public DbSet<Post> Post { get; set; }

        public DbSet<Category> Category { get; set; }

    }
}
