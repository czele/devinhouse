using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiFilmeDatabaseFirst.Context;
using WebApiFilmeDatabaseFirst.DTO;
using WebApiFilmeDatabaseFirst.Models;

namespace WebApiFilmeDatabaseFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeDiretorController : ControllerBase
    {
        private readonly FilmeContext _context;

        public FilmeDiretorController(FilmeContext context)
        {
            _context = context;
        }

        // GET: api/FilmeDiretors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmeDiretor>>> GetFilmeDiretor()
        {
            return await _context.FilmeDiretor.Include(x => x.Filme).Include(y => y.Diretor).ToListAsync();
        }

        // GET: api/FilmeDiretors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmeDiretor>> GetFilmeDiretor(int id)
        {
            var filmeDiretor = await _context.FilmeDiretor.FindAsync(id);

            if (filmeDiretor == null)
            {
                return NotFound();
            }

            return filmeDiretor;
        }

        // PUT: api/FilmeDiretors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmeDiretor(int id, FilmeDiretor filmeDiretor)
        {
            if (id != filmeDiretor.Id)
            {
                return BadRequest();
            }

            _context.Entry(filmeDiretor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmeDiretorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FilmeDiretors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FilmeDiretor>> PostFilmeDiretor(FilmeDiretorDTO filmeDiretorDTO)
        {
            var configuration = new MapperConfiguration(
                )


            _context.FilmeDiretor.Add(filmeDiretor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmeDiretor", new { id = filmeDiretor.Id }, filmeDiretor);
        }

        // DELETE: api/FilmeDiretors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilmeDiretor(int id)
        {
            var filmeDiretor = await _context.FilmeDiretor.FindAsync(id);
            if (filmeDiretor == null)
            {
                return NotFound();
            }

            _context.FilmeDiretor.Remove(filmeDiretor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmeDiretorExists(int id)
        {
            return _context.FilmeDiretor.Any(e => e.Id == id);
        }
    }
}
