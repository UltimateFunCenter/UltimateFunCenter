using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UltimateFunCenter.Data;
using UltimateFunCenter.Model;

namespace UltimateFunCenter.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FacilityId"] = new SelectList(_context.Facilities, "Id", "Description");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            try
            {
                Booking.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _context.Bookings.Add(Booking);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
