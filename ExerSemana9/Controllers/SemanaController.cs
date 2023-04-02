using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerSemana9.Model;
using Microsoft.AspNetCore.Mvc;

namespace ExerSemana9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemanaController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        } 

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post([FromBody] SemanaModel semanaModel)
        {
            return Ok(true);
        }

        [HttpPut]
        public ActionResult Put([FromBody] SemanaModel mesModel)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            return Ok();
        }
    }
}