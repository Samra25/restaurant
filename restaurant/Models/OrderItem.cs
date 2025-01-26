using System.ComponentModel.DataAnnotations.Schema;

namespace restaurant.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public int MenuItemId { get; set; }

        [ForeignKey("MenuItemId")]
        public MenuItem MenuItem { get; set; }

        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
