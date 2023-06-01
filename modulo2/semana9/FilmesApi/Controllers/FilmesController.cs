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
        /// <summary>
        /// Lista mocada de filmes
        /// </summary>
        /// <returns>Retorna uma lista mocada de filmes</returns>
        /// <response code="200">Sucesso no retorno da lista mocada de filmes</response>
        // GET: api/<FilmesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(MockFilmes.Filmes);
        }

        /// <summary>
        /// Requisição do item de uma lista mocada
        /// </summary>
        /// <param name="id">Id do filme</param>
        /// <returns>Retorno do objeto filme</returns>
        /// <response code="404">Filme não encontrado</response>
        /// <response code="200">Sucesso no retorno do item de uma lista</response>
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

        /// <summary>
        /// Criação de um filme
        /// </summary>
        /// <param name="filme">Objeto filme</param>
        /// <returns>Criação do objeto Filme</returns>
        /// <response code="201">Objeto filme criado com sucesso</response>
        // POST api/<FilmesController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] Filme filme)
        {
            MockFilmes.Filmes.Add(filme);
            return CreatedAtAction(nameof(Get), new { id = filme.Id }, filme);
        }

        /// <summary>
        /// Atualização do filme
        /// </summary>
        /// <param name="id">Id do filme</param>
        /// <param name="filme">Objeto Filme</param>
        /// <returns>Atualização do filme</returns>
        /// <response code="404">Filme não encontrado</response>
        /// <response code="204">Atualização de filme realizada com sucesso</response>
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

        /// <summary>
        /// Remoção do filme
        /// </summary>
        /// <param name="id">Id do filme</param>
        /// <returns>Remoção do filme</returns>
        /// <response code="404">Filme não encontrado</response>
        /// <response code="204">Remoção de filme realizada com sucesso</response>
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
