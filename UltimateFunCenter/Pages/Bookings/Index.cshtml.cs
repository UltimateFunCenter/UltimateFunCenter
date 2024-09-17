using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UltimateFunCenter.Data;
using UltimateFunCenter.Model;

namespace UltimateFunCenter.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly UltimateFunCenter.Data.ApplicationDbContext _context;

        public IndexModel(UltimateFunCenter.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Booking = await _context.Bookings
                .Include(b => b.Facility)
                .Include(b => b.User).ToListAsync();
        }
    }
}
