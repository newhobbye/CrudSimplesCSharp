using FuncionariosAPI.Data;
using FuncionariosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FuncionariosAPI.Controllers
{
    [ApiController]
    [Route("/funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private FuncionarioContext _funcionario;

        public FuncionarioController(FuncionarioContext funcionario)
        {
            _funcionario = funcionario;
        }

        [HttpPost]
        public IActionResult AdicionarFuncionario([FromBody] Funcionario funcionario)
        {
            if (funcionario == null)
            {
                return NotFound();
            }

            _funcionario.Funcionarios.Add(funcionario);
            _funcionario.SaveChanges();
            return CreatedAtAction(nameof(RecuperarFuncionario), new { CPF = funcionario.CPF }, funcionario);
        }

        [HttpGet]
        public IEnumerable<Funcionario> RecuperarFuncionario()
        {
            return _funcionario.Funcionarios;
        }

        [HttpGet("{cpf}")]
        public IActionResult RecuperarFuncionariosPorCPF(string cpf)
        {
            Funcionario funcionario = _funcionario.Funcionarios.FirstOrDefault(x => x.CPF == cpf);
            if(funcionario != null)
            {
                return Ok(funcionario);
            }

            return NotFound();
        }

        [HttpDelete("{cpf}")]
        public IActionResult DeletarFuncionariosPorCPF(string cpf)
        {
            Funcionario funcionario = _funcionario.Funcionarios.FirstOrDefault(x => x.CPF == cpf);
            if (funcionario != null)
            {
                _funcionario.Remove(funcionario);
                _funcionario.SaveChanges();
                return NoContent();
            }

            return NotFound();
        }
    }
}
