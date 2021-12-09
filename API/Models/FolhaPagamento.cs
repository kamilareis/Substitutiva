using System;

namespace API.Models
{
    public class FolhaPagamento
    {
        public FolhaPagamento() => CriadaEm = DateTime.Now;
        public int Id {get; set;}
        public int IdFuncionario {get; set;}
        public string CaixaTexto {get; set;}
        public double ValorHora {get; set;}
        public String  MesAno {get; set;}      
        public DateTime  CriadaEm {get; set;}  

        public override string ToString() => 
        $"Id: {Id}  |  IdFuncionario: {IdFuncionario}  |  CaixaTexto: {CaixaTexto}  |  ValorHora: {ValorHora:C6)}  |  MesAno: {MesAno}  |  CriadaEm: {CriadaEm}";
    }
}