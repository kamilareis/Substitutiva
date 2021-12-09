using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private readonly Context contextt;
        public FuncionarioController(Context context) => contextt = context;
        //POST: api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public Funcionario Cadatrar(Funcionario funcionario)
        {            
            contextt.Funcionario.Add(funcionario);
            return funcionario;
        }
    }

    
}