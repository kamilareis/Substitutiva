using System;

namespace API.Models
{
    public class FolhaPagamento
    {
        public int Id {get; set;}
        public int IdFuncionario {get; set;}
        public string CaixaTexto {get; set;}
        public decimal ValorHora {get; set;}
        public DateTime  MesAno {get; set;}      
    }
}