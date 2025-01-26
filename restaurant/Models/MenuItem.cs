using System.ComponentModel.DataAnnotations.Schema;

namespace restaurant.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }

        public bool IsAvailable { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
