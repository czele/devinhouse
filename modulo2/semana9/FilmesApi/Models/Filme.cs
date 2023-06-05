using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo nome é de preenchimento obrigatório")]
        [MaxLength(200, ErrorMessage = "O campo nome não pode exceder 200 caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo diretor é de preenchimento obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo diretor não pode exceder 100 caracteres")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O campo genero é de preenchimento obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo gênero não pode exceder 50 caracteres")]
        public string Genero { get; set; }

        [Required]
        public int Duracao { get; set; }
    }
}
