using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevCars.API.Controllers
{
    [Route("api/cars")]
    public class CarsController : ControllerBase
    {
        // GET api/cars
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET api/cars/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST api/cars/
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        // PUT api/cars/
        [HttpPut("{id}")]
        public IActionResult Put()
        {
            return Ok();
        }

        // DELETE api/cars/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }


    }
}
