using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using C19Test.Data;
using C19Test.Models;
using Microsoft.EntityFrameworkCore;

namespace C19Test.Pages.Cases
{
    public class CreateModel : PageModel
    {
        private readonly C19Test.Data.C19TestContext _context;

        public CreateModel(C19Test.Data.C19TestContext context)
        {
            _context = context;
        }
        public IList<Status> StatusSL { get; set; }
        public async Task<PageResult> OnGetAsync()
        {
            StatusSL = await _context.Status.ToListAsync();
            return Page();
        }

        [BindProperty]
        public Case Case { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cases.Add(Case);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
