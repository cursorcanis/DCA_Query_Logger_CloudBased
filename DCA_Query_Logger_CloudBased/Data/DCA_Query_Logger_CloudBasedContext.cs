using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DCA_Query_Logger_CloudBased.Models;

namespace DCA_Query_Logger_CloudBased.Data
{
    public class DCA_Query_Logger_CloudBasedContext : DbContext
    {
        public DCA_Query_Logger_CloudBasedContext (DbContextOptions<DCA_Query_Logger_CloudBasedContext> options)
            : base(options)
        {
        }

        public DbSet<DCA_Query_Logger_CloudBased.Models.Query> Query { get; set; } = default!;
    }
}
