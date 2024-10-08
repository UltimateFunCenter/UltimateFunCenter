﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UltimateFunCenter.Data;
using UltimateFunCenter.Model;

namespace UltimateFunCenter.Pages.Buildings
{
    [Authorize(Roles="Admin")]
    public class IndexModel : PageModel
    {
        private readonly UltimateFunCenter.Data.ApplicationDbContext _context;

        public IndexModel(UltimateFunCenter.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Building> Building { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Building = await _context.Building.ToListAsync();
        }
    }
}
