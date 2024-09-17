using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UltimateFunCenter.Data;
using UltimateFunCenter.Model;

namespace UltimateFunCenter.Pages.Floors
{
    public class DetailsModel : PageModel
    {
        private readonly UltimateFunCenter.Data.ApplicationDbContext _context;

        public DetailsModel(UltimateFunCenter.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Floor Floor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var floor = await _context.Floor.FirstOrDefaultAsync(m => m.Id == id);
            if (floor == null)
            {
                return NotFound();
            }
            else
            {
                Floor = floor;
            }
            return Page();
        }
    }
}
