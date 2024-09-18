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
    public class IndexModel : PageModel
    {
        private readonly UltimateFunCenter.Data.ApplicationDbContext _context;

        public IndexModel(UltimateFunCenter.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Floor> Floor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Floor = await _context.Floor
                .Include(f => f.Building).ToListAsync();
        }
    }
}
