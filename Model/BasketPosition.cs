using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("BasketPosition")]
    public class BasketPosition :DbContext
    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        [ForeignKey(nameof(ProductID))]
        [NotMapped]
        public  Product? Product{ get; set; }
        public int User { get; set; }
        public int Amount { get; set; }
    }
}
