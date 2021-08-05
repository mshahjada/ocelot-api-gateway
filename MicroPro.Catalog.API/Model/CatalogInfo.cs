using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroPro.Catalog.API.Model
{
    public class CatalogInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
    }
}
