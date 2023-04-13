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
        //variavel do tipo leitura
        private readonly SemanaContext semanaContext;

        //CTOR com parametros (injetado dentro dos parenteses o context)
        //se tenho uma injecao, tenho uma var de leitura acima injetado do tipo context, dentro do ctor , faço a injecao de dependencia

        public SemanaController(SemanaContext semanaContext)
        {
            this.semanaContext = semanaContext;
        }
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
        [HttpPost("POST")]
        public ActionResult Post([FromBody] SemanaModel semanaModel)
            {
             if (semanaModel.Id > 0)
                {
                    return Ok(true);
                }
                {
                    return BadRequest("ID necessita ser maior que 0");
                }
            }
        [HttpPut("PUT")]
        public ActionResult Put([FromBody] SemanaModel semanaModel)
        {
           if (semanaModel.Id != 0)
                {
                    return Ok(true);
                }
                {
                    return BadRequest("ID necessita ser maior que 0");
                }
        }
        [HttpDelete("DELETE")]
        public ActionResult Delete(int id)
        {
            var Id = semanaContext.Semana.Find(id);

            if (Id == null)
            {
                return NotFound();
            }

            semanaContext.Semana.Remove(Id);
            semanaContext.SaveChanges();

            return NoContent();
        }
    }
}
