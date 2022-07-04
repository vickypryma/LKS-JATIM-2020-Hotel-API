using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Data.Entities
{
    [Table("FoodsAndDrinks")]
    public class Food
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public char Type { get; set; }

        public int Price { get; set; }
    }
}
