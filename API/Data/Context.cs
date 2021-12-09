using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options){ }

        public DbSet<Funcionario> Funcionario {get; set;}
        public DbSet<FolhaPagamento> FolhaPagamento {get; set;}
    }
}