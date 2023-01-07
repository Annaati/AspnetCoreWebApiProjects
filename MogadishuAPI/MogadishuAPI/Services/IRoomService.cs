using MogadishuAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MogadishuAPI.Services
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetRoomsAsync();

        Task<Room> getRoomAsync(Guid id);
    }
}
