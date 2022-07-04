using Microsoft.AspNetCore.Mvc;
using HotelAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class RoomController : Controller
    {
        private readonly HotelDbContext _hotelDbContext;
        public RoomController(HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var rooms = await _hotelDbContext.Rooms.Where(room => room.CheckinDateTime <= DateTime.Today && room.CheckoutDateTime > DateTime.Today).ToListAsync();
            return Ok(rooms);
        }
    }
}
