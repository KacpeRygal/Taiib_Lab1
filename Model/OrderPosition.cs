using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("OrderPosition")]
    public class OrderPosition : IEntityTypeConfiguration<OrderPosition>
    {
        [Key]
        public int ID { get; set; }
        public required int OrderID { get; set; }
        [ForeignKey(nameof(OrderID))]
        [NotMapped]
        public Order Order { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public void Configure(EntityTypeBuilder<OrderPosition> builder)
        {
            throw new NotImplementedException();
        }
    }
}
