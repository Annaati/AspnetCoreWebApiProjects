using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MogadishuAPI.Models;

namespace MogadishuAPI.Controllers
{
    [Route("/")]
    [ApiController]
    [ApiVersion("1.0")]
    public class RootController : ControllerBase
    {
        [HttpGet(Name=nameof(GetRoot))]
        [ProducesResponseType(200)]
        public IActionResult GetRoot()
        {
            var response = new RootResponse
            {
                Self =  Link.To(nameof(GetRoot)),
                
                Rooms = Link.ToCollection(nameof(RoomsController.GetAllRooms)),

                HotelInfo = Link.To(nameof(HotelInfoController.getHotelInfo)),

            };
            return Ok(response);
        }
    }
}