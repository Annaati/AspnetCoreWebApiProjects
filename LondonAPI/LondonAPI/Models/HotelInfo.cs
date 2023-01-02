using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LondonAPI.Models
{
    public class HotelInfo : Resource
    {
        public String Title { get; set; }
        public String Tagline { get; set; }
        public String Email { get; set; }
        public String Website { get; set; }
        public Address Location { get; set; }
    }

    public class Address
    {
        public String Street { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
    }
}
