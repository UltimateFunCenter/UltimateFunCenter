using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UltimateFunCenter.Model;

namespace UltimateFunCenter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Building> Building { get; set; }
        public DbSet<Floor> Floor { get; set; }
        public DbSet<Facility> Facilities { get; set; }

        public DbSet<Booking> Bookings { get; set; }
    }
}
