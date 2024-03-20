using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Order")]
    public class Order : IEntityTypeConfiguration<Order>
    {
        [Key]
        public int ID { get; set; }
        public required int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        [NotMapped]
        public User User { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<OrderPosition>? OrderPositions { get; set; }

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
            .HasMany(x => x.OrderPositions)
            .WithOne(x => x.Order)
            .OnDelete(DeleteBehavior.Cascade); 


        }
    }
}