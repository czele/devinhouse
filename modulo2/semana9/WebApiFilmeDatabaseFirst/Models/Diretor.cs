using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFilmeDatabaseFirst.Models
{
    public class Diretor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(150, ErrorMessage ="Este campo aceita até 150 caracteres")]
        [MinLength(3, ErrorMessage = "Deve ter no mínimo 3 caracteres")]
        public string Nome { get; set; }

        public string Telefone { get; set; }
    }
}
