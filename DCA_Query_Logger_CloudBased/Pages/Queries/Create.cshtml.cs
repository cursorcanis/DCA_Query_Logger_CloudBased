using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DCA_Query_Logger_CloudBased.Data;
using DCA_Query_Logger_CloudBased.Models;

namespace DCA_Query_Logger_CloudBased.Pages.Queries
{
    public class CreateModel : PageModel
    {
        private readonly DCA_Query_Logger_CloudBased.Data.DCA_Query_Logger_CloudBasedContext _context;

        public CreateModel(DCA_Query_Logger_CloudBased.Data.DCA_Query_Logger_CloudBasedContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Query Query { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Query == null || Query == null)
            {
                return Page();
            }

            _context.Query.Add(Query);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
