using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using MogadishuAPI.Models;

namespace MogadishuAPI.Services
{
    public class RoomService : IRoomService
    {
        private readonly HotelAPIDbContext _context;
        private readonly IConfigurationProvider _mappingConfiguration;

        public  RoomService(
                              HotelAPIDbContext context, 
                              IConfigurationProvider mappingConfiguration
                           )
        {
            _context = context;
            _mappingConfiguration = mappingConfiguration;
        }

        public async Task<Room> getRoomAsync(Guid id)
        {
            var entity = await _context.Rooms.SingleOrDefaultAsync(x => x.Id == id);

            if(entity == null)
            {
                return null;
            }
            var mapper = _mappingConfiguration.CreateMapper();
            return mapper.Map<Room>(entity);
        }

        public async Task<IEnumerable<Room>> GetRoomsAsync()
        {
            var query = _context.Rooms.ProjectTo<Room>(_mappingConfiguration);

            return await query.ToArrayAsync();
        }

    }
}
