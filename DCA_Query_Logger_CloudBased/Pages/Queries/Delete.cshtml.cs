using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DCA_Query_Logger_CloudBased.Data;
using DCA_Query_Logger_CloudBased.Models;

namespace DCA_Query_Logger_CloudBased.Pages.Queries
{
    public class DeleteModel : PageModel
    {
        private readonly DCA_Query_Logger_CloudBased.Data.DCA_Query_Logger_CloudBasedContext _context;

        public DeleteModel(DCA_Query_Logger_CloudBased.Data.DCA_Query_Logger_CloudBasedContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Query Query { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Query == null)
            {
                return NotFound();
            }

            var query = await _context.Query.FirstOrDefaultAsync(m => m.Id == id);

            if (query == null)
            {
                return NotFound();
            }
            else 
            {
                Query = query;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Query == null)
            {
                return NotFound();
            }
            var query = await _context.Query.FindAsync(id);

            if (query != null)
            {
                Query = query;
                _context.Query.Remove(Query);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
