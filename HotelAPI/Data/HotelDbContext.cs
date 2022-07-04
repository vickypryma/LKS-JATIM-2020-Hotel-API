using Microsoft.EntityFrameworkCore;
using HotelAPI.Data.Entities;

namespace HotelAPI.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {

        }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<FDCheckOut> CheckOuts { get; set; }
    }
}
