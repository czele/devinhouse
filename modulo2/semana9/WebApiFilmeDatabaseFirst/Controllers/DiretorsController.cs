using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiFilmeDatabaseFirst.Context;
using WebApiFilmeDatabaseFirst.Models;

namespace WebApiFilmeDatabaseFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiretorsController : ControllerBase
    {
        private readonly FilmeContext _context;

        public DiretorsController(FilmeContext context)
        {
            _context = context;
        }

        // GET: api/Diretors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Diretor>>> GetDiretores()
        {
            return await _context.Diretores.ToListAsync();
        }

        // GET: api/Diretors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Diretor>> GetDiretor(int id)
        {
            var diretor = await _context.Diretores.FindAsync(id);

            if (diretor == null)
            {
                return NotFound();
            }

            return diretor;
        }

        // PUT: api/Diretors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiretor(int id, Diretor diretor)
        {
            if (id != diretor.Id)
            {
                return BadRequest();
            }

            _context.Entry(diretor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiretorExists(id))
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

        // POST: api/Diretors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Diretor>> PostDiretor(Diretor diretor)
        {
            _context.Diretores.Add(diretor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDiretor", new { id = diretor.Id }, diretor);
        }

        // DELETE: api/Diretors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiretor(int id)
        {
            var diretor = await _context.Diretores.FindAsync(id);
            if (diretor == null)
            {
                return NotFound();
            }

            _context.Diretores.Remove(diretor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DiretorExists(int id)
        {
            return _context.Diretores.Any(e => e.Id == id);
        }
    }
}
