using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("OrderPosition")]
    public class OrderPosition :DbContext
    {
        [Key]
        public int ID { get; set; }
        public required int OrderID { get; set; }
        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
    }
}
