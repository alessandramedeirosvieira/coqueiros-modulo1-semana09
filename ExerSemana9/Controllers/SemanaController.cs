using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerSemana9.Model;
using Microsoft.AspNetCore.Mvc;

namespace ExerSemana9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SemanaController : ControllerBase
    {
         [HttpGet("GET")]
        public ActionResult Get()
        {
            return Ok();
        } 

        [HttpGet("GET/{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost("POST")]
        public ActionResult Post([FromBody] SemanaModel semanaModel)
        {
            return Ok(true);
        }

        [HttpPut ("PUT")]
        public ActionResult Put([FromBody] SemanaModel mesModel)
        {
            return Ok();
        }

        [HttpDelete("DELETE/{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            return Ok();
        }
    }
}
