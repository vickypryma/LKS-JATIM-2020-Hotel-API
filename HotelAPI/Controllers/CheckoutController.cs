using Microsoft.AspNetCore.Mvc;
using HotelAPI.Data;
using HotelAPI.Data.Entities;

namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : Controller
    {
        private readonly HotelDbContext _hotelDbContext;

        public CheckoutController(HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post(FDCheckOut payload)
        {
            _hotelDbContext.CheckOuts.Add(payload);
            await _hotelDbContext.SaveChangesAsync();
            return Ok(payload);
        }
    }
}
