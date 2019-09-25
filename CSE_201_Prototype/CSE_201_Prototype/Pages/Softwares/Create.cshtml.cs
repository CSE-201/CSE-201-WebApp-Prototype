using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CSE_201_Prototype.Data;
using CSE_201_Prototype.Models;

namespace CSE_201_Prototype.Pages.Softwares
{
    public class CreateModel : PageModel
    {
        private readonly CSE_201_Prototype.Data.PrototypeContext _context;

        public CreateModel(CSE_201_Prototype.Data.PrototypeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Software Software { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Software.Add(Software);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
