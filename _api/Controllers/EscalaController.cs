using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EscalaController : ControllerBase
    {
        Utils.Escalaconversor convert = new Utils.Escalaconversor();
        Business.EscalaBusiness funcaorn = new Business.EscalaBusiness();

        [HttpGet("{codigo}")]
        public ActionResult<Models.Response.EscalaResponse> ConsultarEscalaFuncionario(string codigo)
        {
            try
            {
                Models.TbEscalaDeTrabalho consulta = funcaorn.ConsultarEscalaFuncionario(codigo);

                return convert.ConvertParaResponse(consulta);
            }
            catch (System.Exception ex)
            {
                return BadRequest(new Models.Response.Erro(404, ex.Message));
            }
        } 
    }
}