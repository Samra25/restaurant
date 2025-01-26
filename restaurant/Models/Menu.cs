using System.ComponentModel.DataAnnotations.Schema;

namespace restaurant.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RestaurantId { get; set; }

        [ForeignKey("RestaurantId")]
        public Restaurant Restaurant { get; set; }

        [InverseProperty("Menu")]
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
