using Microsoft.Extensions.DependencyInjection;
using MogadishuAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MogadishuAPI
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            await AddTestData(
                services.GetRequiredService<HotelAPIDbContext>());
        }

        public static async Task AddTestData(HotelAPIDbContext dbContext)
        {
            if (dbContext.Rooms.Any())
            {
                return;
            }

            dbContext.Rooms.Add(new RoomEntity
            {
                Id = Guid.Parse("301df04d-8679-4b1b-ab92-0a586ae53d08"),
                Name = "Luxury Suite 1",
                Rate = 10119,
            });

            dbContext.Rooms.Add(new RoomEntity
            {
                Id = Guid.Parse("ee2b83be-91db-4de5-8122-35a9e9195976"),
                Name = "Double Comfort Suite",
                Rate = 23959
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
