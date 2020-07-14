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
    public class FuncionarioController : ControllerBase
    {
        Utils.FuncionarioConversor convert = new Utils.FuncionarioConversor();
        Business.FuncionarioBusiness funcaorn = new Business.FuncionarioBusiness();

        [HttpGet("{codigo}")]
        public ActionResult<Models.Response.FuncionarioResponse> ConsultarCodigoFuncionario(string codigo)
        {
            try
            {
                Models.TbFuncionario consulta = funcaorn.ConsultarCodigoFuncionario(codigo);

                return  convert.ConvertparaResponse(consulta);
            }
            catch (System.Exception ex)
            {
                return UnprocessableEntity(
                    new Models.Response.Erro(422, ex.Message)
                );
            }
        }
    }
}