using Microsoft.EntityFrameworkCore;
using PreliminaryTechnicalQuestion.Domain.Entities;

namespace PreliminaryTechnicalQuestion.Domain
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Room> Room { get; set; }
        public DbSet<Booking> Booking { get; set; }
    }
}