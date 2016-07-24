using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.EFModels
{
    [Table("Part")]
    public partial class Part
    {
        public Part()
        {
            Transaction = new HashSet<Transaction>();
            
        }

        [Key]
        public int QuickID { get; set; }
        
        public string Category { get; set; }

        public string PartNumber { get; set; }//

        public string Location { get; set; }

        public string SerialNumber { get; set; }//

        public string Description { get; set; }//

        public string Notes { get; set; }

        public string Quantity { get; set; }
        
        public virtual ICollection<Transaction> Transaction { get; set; }

    }

    public class PartConfiguration : EntityTypeConfiguration<Part>
    {
        public PartConfiguration()
        {
            HasMany(e => e.Transaction);

            
        }
    }
}
