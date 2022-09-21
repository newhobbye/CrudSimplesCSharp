using System;
using System.ComponentModel.DataAnnotations;

namespace FuncionariosAPI.Models
{
    public class Funcionario
    {
        [Key]
        [Required(ErrorMessage = "Campo CPF é obrigatório!")]
       // [Range(1,12)]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Idade valida entre 18 a 65!")]
        [Range(18, 65)]
        public int Age { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string  Street { get; set; }
        [Required]
        public int NumberOfStreet { get; set; }

    }
}
