using Microsoft.EntityFrameworkCore;

namespace PreliminaryTechnicalQuestion.Domain
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<RoomDto> Room { get; set; }
        public DbSet<BookingDto> Booking { get; set; }
    }
}