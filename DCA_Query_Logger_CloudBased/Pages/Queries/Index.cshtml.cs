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
    public class IndexModel : PageModel
    {
        private readonly DCA_Query_Logger_CloudBased.Data.DCA_Query_Logger_CloudBasedContext _context;

        public IndexModel(DCA_Query_Logger_CloudBased.Data.DCA_Query_Logger_CloudBasedContext context)
        {
            _context = context;
        }

        public IList<Query> Query { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Query != null)
            {
                Query = await _context.Query.ToListAsync();
            }
        }
    }
}
