using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UltimateFunCenter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object Customer;
        internal object Facility;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public object Booking { get; internal set; }
    }
}
