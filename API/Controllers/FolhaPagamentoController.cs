using System;
using System.Collections.Generic;
using System.Linq;
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
        public FolhaPagamento Cadatrar([FromBody] FolhaPagamento folhapagamento)
        {
            contextt.FolhaPagamento.Add(folhapagamento);
            contextt.SaveChanges();
            return folhapagamento;
        }
        [HttpGet]
        [Route("list")]
        public List<FolhaPagamento> List() => contextt.FolhaPagamento.ToList();
        
        [HttpGet]
        [Route("getbyid")]
        public FolhaPagamento GetById(int id)
        {
            Console.WriteLine($"Id: {id}");
            return null;
        }
    }
}