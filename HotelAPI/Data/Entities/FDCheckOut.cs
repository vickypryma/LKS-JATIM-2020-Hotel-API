using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Data.Entities
{
    [Table("FDCheckOut")]
    public class FDCheckOut
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int ReservationRoomID { get; set; }

        public int FDID { get; set; }

        public int Qty { get; set; }

        public int TotalPrice { get; set; }

        public int EmployeeID { get; set; }
    }
}
