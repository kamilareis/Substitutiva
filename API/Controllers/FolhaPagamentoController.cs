using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/folhapagamento")]
    public class FolhaPagamentoController
    {
        private readonly Context contextt;
        public FolhaPagamentoController(Context context) => contextt = context;
        //POST: api/folhapagamento/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public FolhaPagamento Cadatrar(FolhaPagamento folhapagamento)
        {
            contextt.FolhaPagamento.Add(folhapagamento);
            return folhapagamento;
        }

    }
}