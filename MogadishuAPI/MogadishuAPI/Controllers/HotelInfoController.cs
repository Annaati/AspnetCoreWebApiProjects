using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MogadishuAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace MogadishuAPI.Controllers
{
    [Route("/[Controller]")]
    [ApiController]
    public class HotelInfoController : ControllerBase
    {
        private readonly HotelInfo _hotelInfo;
        public HotelInfoController(IOptions<HotelInfo> hotelInfoWrapper)
        {
            _hotelInfo = hotelInfoWrapper.Value;
        }

        [HttpGet(Name = nameof(getHotelInfo))]
        [ProducesResponseType(200)]
        public ActionResult<HotelInfo> getHotelInfo()
        {
            _hotelInfo.Href = Url.Link(nameof(getHotelInfo), null);
            return _hotelInfo;
        }
    }
}