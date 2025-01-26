using System.ComponentModel.DataAnnotations.Schema;

namespace restaurant.Models
{
    public class Restaurant

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OpeningHours { get; set; }

        [InverseProperty("Restaurant")]
        public ICollection<Menu> Menus { get; set; }

        [InverseProperty("Restaurant")]
        public ICollection<Reservation> Reservations { get; set; }
    }
}
