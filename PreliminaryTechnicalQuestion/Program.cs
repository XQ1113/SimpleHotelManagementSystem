using Microsoft.EntityFrameworkCore;
using PreliminaryTechnicalQuestion.Domain;
using PreliminaryTechnicalQuestion.Presentation;

namespace PreliminaryTechnicalQuestion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase(builder.Configuration.GetConnectionString("MyDatabase")));

            var app = builder.Build();

            app.MapRoomEndpoint();

            app.MapBookingEndpoint();

            app.Run();
        }
    }
}