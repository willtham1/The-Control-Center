using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Control_Center.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        // CategoryId is a foreign key
        public int CategoryId { get; set; }
        public Category Category { get; set; } 

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
