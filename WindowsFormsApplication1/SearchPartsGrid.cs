using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApplication1.Enums;

namespace WindowsFormsApplication1
{
    public class SearchPartsGrid
    {


        public List<int> QuickID { get; set; }
        public List<string> PartNumber { get; set; }
        public List<string> SerialNumber { get; set; }
        public List<string> PartDescription { get; set; }
        public List<string> Location { get; set; }
        public List<string> Category { get; set; }
        public List<string> Quantity { get; set; }
        

    }
}
