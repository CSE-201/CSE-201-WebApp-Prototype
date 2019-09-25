﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CSE_201_Prototype.Data;
using CSE_201_Prototype.Models;

namespace CSE_201_Prototype.Pages.Softwares
{
    public class DetailsModel : PageModel
    {
        private readonly CSE_201_Prototype.Data.PrototypeContext _context;

        public DetailsModel(CSE_201_Prototype.Data.PrototypeContext context)
        {
            _context = context;
        }

        public Software Software { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Software = await _context.Software.FirstOrDefaultAsync(m => m.UrlAddress == id);

            if (Software == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
