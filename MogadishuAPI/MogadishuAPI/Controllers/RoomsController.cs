using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MogadishuAPI.Controllers
{
    [Route("/[Controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        [HttpGet(Name = nameof(GetRooms))]
        [ProducesResponseType(200)]
        public IActionResult GetRooms()
        {
            throw new NotImplementedException();
        }
    }
}