using System.ComponentModel.DataAnnotations.Schema;

namespace restaurant.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public int TotalAmount { get; set; }

        [InverseProperty("Order")]
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
