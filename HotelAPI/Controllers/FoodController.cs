using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelAPI.Data;

namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : Controller
    {
        private readonly HotelDbContext _hotelDbContext;

        public FoodController(HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var foods = await _hotelDbContext.Foods.ToListAsync();
            return Ok(foods);
        }
    }
}
