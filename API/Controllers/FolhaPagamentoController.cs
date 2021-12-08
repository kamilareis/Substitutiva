using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/folhapagamento")]
    public class FolhaPagamentoController
    {
        //POST: api/folhapagamento/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public FolhaPagamento Cadatrar(FolhaPagamento folhapagamento)
        {
            //select * funcionario;
            return folhapagamento;
        }
    }
}