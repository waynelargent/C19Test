using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using C19Test.Models;

namespace C19Test.Data
{
    public class C19TestContext : DbContext
    {
        public C19TestContext (DbContextOptions<C19TestContext> options)
            : base(options)
        {
        }

        public DbSet<C19Test.Models.Case> Cases { get; set; }

        public DbSet<C19Test.Models.Status> Status { get; set; }

        public DbSet<C19Test.Models.Location> Location { get; set; }
    }
}
