using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using C19Test.Data;
using C19Test.Models;

namespace C19Test.Pages.Statuses
{
    public class DetailsModel : PageModel
    {
        private readonly C19Test.Data.C19TestContext _context;

        public DetailsModel(C19Test.Data.C19TestContext context)
        {
            _context = context;
        }

        public Status Status { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Status = await _context.Status.FirstOrDefaultAsync(m => m.StatusID == id);

            if (Status == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
