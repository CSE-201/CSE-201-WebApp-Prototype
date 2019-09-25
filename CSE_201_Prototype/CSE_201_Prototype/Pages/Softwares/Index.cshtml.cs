using System;
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
    public class IndexModel : PageModel
    {
        private readonly CSE_201_Prototype.Data.PrototypeContext _context;

        public IndexModel(CSE_201_Prototype.Data.PrototypeContext context)
        {
            _context = context;
        }

        public IList<Software> Software { get;set; }

        public async Task OnGetAsync()
        {
            Software = await _context.Software.ToListAsync();
        }
    }
}
