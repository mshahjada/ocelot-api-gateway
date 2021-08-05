using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MicroPro.Basket.API.Model;

namespace MicroPro.Basket.API.Controllers
{
    [Route("api/basket")]
    [ApiController]
    public class BasketController : ControllerBase
    {

        private readonly List<BasketInfo> _basketInofs = new List<BasketInfo>()
                                            {
                                                new BasketInfo() {Id = 1, BasketNo = "BS001", CreatedDateUtc = DateTime.UtcNow },
                                                new BasketInfo() {Id = 2, BasketNo = "BS002", CreatedDateUtc = DateTime.UtcNow },
                                                new BasketInfo() {Id = 3, BasketNo = "BS003", CreatedDateUtc = DateTime.UtcNow },
                                                new BasketInfo() {Id = 4, BasketNo = "BS004", CreatedDateUtc = DateTime.UtcNow },
                                            };
             
        public BasketController()
        {

        }

        [HttpGet("get/{id:long}")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(BasketInfo), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetByBasket(long id)
        {
            if (id < 0) return BadRequest();

            var res = _basketInofs.FirstOrDefault(x => x.Id == id);

            if (res != null)
                return Ok(res);

            return NotFound();

        }


    }
}
