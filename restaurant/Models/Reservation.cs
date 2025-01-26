using System.ComponentModel.DataAnnotations.Schema;

namespace restaurant.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberOfGuests { get; set; }
        public int RestaurantId { get; set; }

        [ForeignKey("RestaurantId")]
        public Restaurant Restaurant { get; set; }
    }
}
