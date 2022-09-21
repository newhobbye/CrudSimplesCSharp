using FuncionariosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosAPI.Data
{
    public class FuncionarioContext: DbContext
    {

        public FuncionarioContext(DbContextOptions<FuncionarioContext> opt)
            :base(opt)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
