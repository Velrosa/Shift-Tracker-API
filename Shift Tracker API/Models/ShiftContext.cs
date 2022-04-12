using System;
using Microsoft.EntityFrameworkCore;
namespace Shift_Tracker_API.Models
{
    public class ShiftContext : DbContext
    {
        public ShiftContext(DbContextOptions<ShiftContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Shift> Shifts { get; set; }
    }
}
