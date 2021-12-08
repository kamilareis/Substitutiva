using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/funcionario")]
    public class FuncionarioController : ControllerBase
    {
        //POST: api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public Funcionario Cadatrar(Funcionario funcionario)
        {
            funcionario.Nome += "cadastrado"; 
            return funcionario;
        }
    }
}