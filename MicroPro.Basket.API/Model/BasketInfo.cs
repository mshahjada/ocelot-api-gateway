using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroPro.Basket.API.Model
{
    public class BasketInfo
    {
        public int Id { get; set; }
        public string BasketNo { get; set; }
        public DateTime CreatedDateUtc { get; set; }
    }
}
