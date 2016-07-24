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
    [Table("Tech")]
    public partial class Tech
    {
        public Tech()
        {
            Transaction = new HashSet<Transaction>();
        }

        [Key]
        public int TechID { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public virtual ICollection<Transaction>  Transaction { get; set; }

    }

    public class TechConfiguration : EntityTypeConfiguration<Tech>
    {
        public TechConfiguration()
        {
            HasMany(e => e.Transaction);
        }
    }
}
