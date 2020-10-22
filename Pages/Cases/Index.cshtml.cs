using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using C19Test.Data;
using C19Test.Models;

namespace C19Test.Pages.Cases
{
    public class IndexModel : PageModel
    {
        private readonly C19Test.Data.C19TestContext _context;

        public IndexModel(C19Test.Data.C19TestContext context)
        {
            _context = context;
        }

        public IList<Case> Case { get;set; }
        
        public async Task OnGetAsync()
        {
            Case = await _context.Cases.ToListAsync();
        }
    }
}
