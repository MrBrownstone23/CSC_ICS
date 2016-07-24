using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApplication1.Enums;

namespace WindowsFormsApplication1.EFModels
{
    [Table("Transaction")]
    public partial class Transaction
    {
        public Transaction()
        {
            
        }

        [Key]
        public int TransactionID { get; set; }

        [Required]
        public int QuickID { get; set; }

        [Required]
        public int TechID { get; set; }

        public EnumTransactionType? TransactionType { get; set; }
        
        public int Quantity { get; set; }

        public string Destination { get; set; }

        public string Reason { get; set; }

        public DateTime? TimeStamp { get; set; }

        
    }

    public class TransactionConfiguration : EntityTypeConfiguration<Transaction>
    {
        public TransactionConfiguration()
        {

        }
    }
}
