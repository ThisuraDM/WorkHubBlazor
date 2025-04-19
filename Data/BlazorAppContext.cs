using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Models;

namespace BlazorApp.Data
{
    public class BlazorAppContext : DbContext
    {
        public BlazorAppContext (DbContextOptions<BlazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp.Models.Worker> Worker { get; set; } = default!;
        public DbSet<BlazorApp.Models.Occupation> Occupation { get; set; } = default!;
        public DbSet<BlazorApp.Models.WorkerOccupation> WorkerOccupation { get; set; } = default!;
        public DbSet<BlazorApp.Models.Customer> Customer { get; set; } = default!;
    }
}
