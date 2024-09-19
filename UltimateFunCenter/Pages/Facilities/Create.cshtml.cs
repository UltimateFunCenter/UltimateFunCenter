using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UltimateFunCenter.Data;
using UltimateFunCenter.Model;

namespace UltimateFunCenter.Pages.Facilities
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
            ViewData["FloorId"] = new SelectList(_context.Floor, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Facility Facility { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                _context.Facilities.Add(Facility);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex) {

                if (!ModelState.IsValid)
                {
                    return Page();
                }
            }

           

          

            return RedirectToPage("./Index");
        }
    }
}
