using System;
using Microsoft.EntityFrameworkCore;

namespace ActivityTracker.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Activity> Activities { get; set; }
    }
}
