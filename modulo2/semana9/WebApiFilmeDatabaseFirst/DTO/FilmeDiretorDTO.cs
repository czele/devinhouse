using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFilmeDatabaseFirst.DTO
{
    public class FilmeDiretorDTO
    {
        [Required]
        public int IdFilme { get; set; }
        public int IdDiretor { get; set; }
    }
}
