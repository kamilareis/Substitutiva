using System;

namespace API.Models
{
    public class Funcionario
    {
        public Funcionario() => CriadoEm = DateTime.Now;
        public int Id {get; set;}
        public char Cpf {get; set;}
        public string Nome {get; set;}
        public DateTime CriadoEm {get; set;}
    }
}