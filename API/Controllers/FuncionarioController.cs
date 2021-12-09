using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Cadatrar([FromBody] Funcionario funcionario)
        {            
            contextt.Funcionario.Add(funcionario);
            contextt.SaveChanges();
            return Created("", funcionario);
        }

        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(contextt.Funcionario.ToList());
        
        [HttpGet]
        [Route("getbyid/[id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Funcionario funcionario = contextt.Funcionario.Find(id);
            if(funcionario == null){
                return NotFound();
            }
            return  Ok(funcionario);
        }

        [HttpGet]
        [Route("delete/[name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            
            Funcionario funcionario = contextt.Funcionario.FirstOrDefault(funcionario => funcionario.Nome == name);
            if(funcionario== null){
                return NotFound();
            }
            contextt.Funcionario.Remove(funcionario);
            contextt.SaveChanges();
            return Ok(contextt.Funcionario.ToList());
        }
    }

    
}