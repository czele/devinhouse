using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmesApi.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FilmesApi.Controllers
{
    [Route("api/filmes")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        // GET: api/<FilmesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(MockFilmes.Filmes);
        }

        // GET api/<FilmesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get(int id)
        {
            Filme filme = MockFilmes.Filmes.FirstOrDefault(x => x.Id == id);

            if (filme is null)
            {
                return NotFound();
            }
            return Ok(filme);
        }

        // POST api/<FilmesController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] Filme filme)
        {
            MockFilmes.Filmes.Add(filme);
            return CreatedAtAction(nameof(Get), new { id = filme.Id }, filme);
        }

        // PUT api/<FilmesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Put(int id, [FromBody] Filme filme)
        {
            Filme filmeUpdate = MockFilmes.Filmes.FirstOrDefault(x => x.Id == id);
            if(filmeUpdate is null)
            {
                return NotFound();
            }
            var index = MockFilmes.Filmes.IndexOf(filmeUpdate);

            if(index != -1)
            {
                MockFilmes.Filmes[index] = filme;
            }
            return NoContent();
        }

        // DELETE api/<FilmesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete(int id)
        {
            Filme filmeUpdate = MockFilmes.Filmes.FirstOrDefault(x => x.Id == id);
            if (filmeUpdate is null)
            {
                return NotFound();
            }

            MockFilmes.Filmes.Remove(filmeUpdate);

            return NoContent();

        }
    }
}
