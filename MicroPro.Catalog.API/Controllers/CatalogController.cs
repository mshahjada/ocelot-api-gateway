using MicroPro.Catalog.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MicroPro.Catalog.API.Controllers
{
    [Route("api/catalog")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly List<CatalogInfo> _catalogInfo = new List<CatalogInfo>()
                                            {
                                                new CatalogInfo() {Id = 1, Name = "Mobile", CreatedDateUtc = DateTime.UtcNow },
                                                new CatalogInfo() {Id = 2, Name = "Laptop", CreatedDateUtc = DateTime.UtcNow },
                                                new CatalogInfo() {Id = 3, Name = "Chair", CreatedDateUtc = DateTime.UtcNow },
                                                new CatalogInfo() {Id = 4, Name = "Mouse", CreatedDateUtc = DateTime.UtcNow },
                                            };

        public CatalogController()
        {

        }

        [HttpGet("get/{id:long}")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(CatalogInfo), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetByCatalog(long id)
        {
            if (id < 0) return BadRequest();

            var res = _catalogInfo.FirstOrDefault(x => x.Id == id);

            if (res != null)
                return Ok(res);

            return NotFound();

        }
    }
}
