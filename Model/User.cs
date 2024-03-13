using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("User")]
    public class User: DbContext
    {
        [Key]
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public enum Type { Admin, Casual }
        public IEnumerable<BasketPosition>? BasketPositions { get; set; }
        public IEnumerable<Order>? Order { get; set; }
    }
}
