using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.EFModels;

namespace WindowsFormsApplication1.DBContext
{
    public class InventoryContext : DbContext
    {        
        public DbSet<Tech> Tech { get; set; }
        public DbSet<Part> Part { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
    }
}
