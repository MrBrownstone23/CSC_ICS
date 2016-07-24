using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.EFModels;

namespace WindowsFormsApplication1
{
    public class EntityViewModel
    {
    }

    public class PartsGridInfo
    {
        public int QuickID { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Quantity { get; set; }
        public List<TransactionGridInfo> Transaction { get; set; }


    }

    public class TransactionGridInfo
    {
        public string Destination { get; set; }
        public string Reason { get; set; }
        public int TransactionQuantity { get; set; }
        public DateTime? TransactionDate { get; set; }
        
        
        public string TechFullName { get; set; }
    }

    
}
