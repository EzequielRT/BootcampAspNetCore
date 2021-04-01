using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCars.API.InputModels;
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
            // RETORNA LISTA DE CarItemViewModel
            return Ok();
        }

        // GET api/cars/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // SE CARRO DE IDENTIFICADOR ID NAO EXISTIR, RETORNA "NOT FOUND (404)"
            // SENAO, OK
            return Ok();
        }

        // POST api/cars/
        [HttpPost]
        public IActionResult Post([FromBody] AddCarInputModel model)
        {
            // SE O CADASTRO FUNCIONAR, RETORNA "CREATED (201)"
            // SE OS DADOS DE ENTRADA ESTIVEREM INCORRETOS, RETORNA "BAD REQUEST (400)"
            // SE O CADASTRO FUNCIONAR, MAS NAO TIVER UMA API DE CONSULTA, RETORNA "NO CONTENT (204)"
            return Ok();
        }

        // PUT api/cars/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateCarInputModel model)
        {
            // SE A ATUALIZACAO FUNCIONAR, RETORNA "NO CONTENT (204)"
            // SE OS DADOS DE ENTRADA ESTIVEREM INCORRETOS, RETORNA "BAD REQUEST (400)"
            // SE NAO EXISTIR, RETORNA "NOT FOUND (404)"
            return Ok();
        }

        // DELETE api/cars/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // SE NAO EXISTIR, RETORNA "NOT FOUND (404)"
            // SE FOR COM SUCESSO, RETORNA "NO CONTENT (204)"
            return Ok();
        }


    }
}
