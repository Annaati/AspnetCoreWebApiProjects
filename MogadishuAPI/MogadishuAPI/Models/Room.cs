using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MogadishuAPI.Models
{
    public class Room : Resource
    {
        public string Name { get; set; }
        public decimal Rate { get; set; }
    }
}
