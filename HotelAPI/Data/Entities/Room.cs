using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Data.Entities
{
    [Table("ViewReservationRoom")]
    public class Room
    {
        public int ID { get; set; }

        public int RoomID { get; set; }

        public DateTime CheckinDateTime { get; set; }

        public DateTime CheckoutDateTime { get; set; }

        public int RoomNumber { get; set; }
    }
}
