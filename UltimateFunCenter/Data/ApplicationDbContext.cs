using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UltimateFunCenter.Models;

namespace UltimateFunCenter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UltimateFunCenter.Models.Booking> Booking { get; set; } = default!;
        public DbSet<UltimateFunCenter.Models.Facility> Facility { get; set; } = default!;
        public DbSet<UltimateFunCenter.Models.Customer> Customer { get; set; } = default!;

       

    }
}
