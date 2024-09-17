using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UltimateFunCenter.Data;
using UltimateFunCenter.Model;

namespace UltimateFunCenter.Pages.Floors
{
    public class CreateModel : PageModel
    {
        private readonly UltimateFunCenter.Data.ApplicationDbContext _context;

        public CreateModel(UltimateFunCenter.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BuildingId"] = new SelectList(_context.Building, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Floor Floor { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Floor.Add(Floor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
