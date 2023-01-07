using Microsoft.EntityFrameworkCore;
using MogadishuAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MogadishuAPI
{
    public class HotelAPIDbContext : DbContext
    {
        public HotelAPIDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<RoomEntity> Rooms { get; set; }
    }
}
