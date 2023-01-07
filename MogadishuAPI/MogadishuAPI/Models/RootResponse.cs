using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MogadishuAPI.Models
{
    public class RootResponse : Resource
    {
        public Link Rooms { get; set; }
        public Link HotelInfo { get; set; }
    }
}
