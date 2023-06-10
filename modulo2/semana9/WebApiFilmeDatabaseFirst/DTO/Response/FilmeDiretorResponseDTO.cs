using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApiFilmeDatabaseFirst.Models;

namespace WebApiFilmeDatabaseFirst.DTO.Response
{
    public class FilmeDiretorResponseDTO
    {
        [ForeignKey("Filme")]
        public int IdFilme { get; set; }

        [ForeignKey("Diretor")]
        public int IdDiretor { get; set; }

        public virtual Diretor Diretor { get; set; }
        public virtual Filme Filme { get; set; }
    }
}
