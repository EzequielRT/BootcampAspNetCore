using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCars.API.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace DevCars.API.Controllers
{
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        // POST api/customers
        [HttpPost]
        public IActionResult Post([FromBody] AddCustomerInputModel model)
        {
            return Ok();
        }

        // POST api/customers/2/orders
        [HttpPost("{id}")]
        public IActionResult PostOrder(int id, [FromBody] AddCarInputModel model)
        {
            return Ok();
        }

        // GET api/customers/2/orders/1
        [HttpGet("{id}/orders/{orderid}")]
        public IActionResult GetOrder(int id, int orderid)
        {
            return Ok();
        }
    }
}
