using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevCars.API.Controllers
{
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        // POST api/customers
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        // POST api/customers/2/orders
        [HttpPost("{id}")]
        public IActionResult PostOrder(int id)
        {
            return Ok();
        }

        // GET api/customers/2/orders
        [HttpGet("{id}/orders/{orderid}")]
        public IActionResult GetOrder(int id, int orderid)
        {
            return Ok();
        }
    }
}
