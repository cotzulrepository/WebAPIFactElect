using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIFactElect.Context;
using APIFactElect.Models;

namespace APIFactElect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstablecimientosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EstablecimientosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Establecimientos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Establecimientos>>> GetEstablecimientos()
        {
            return await _context.Establecimientos.ToListAsync();
        }

        // GET: api/Establecimientos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Establecimientos>> GetEstablecimientos(long id)
        {
            var establecimientos = await _context.Establecimientos.FindAsync(id);

            if (establecimientos == null)
            {
                return NotFound();
            }

            return establecimientos;
        }

        // PUT: api/Establecimientos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstablecimientos(long id, Establecimientos establecimientos)
        {
            if (id != establecimientos.codigo)
            {
                return BadRequest();
            }

            _context.Entry(establecimientos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstablecimientosExists(id))
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

        // POST: api/Establecimientos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Establecimientos>> PostEstablecimientos(Establecimientos establecimientos)
        {
            _context.Establecimientos.Add(establecimientos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstablecimientos", new { id = establecimientos.codigo }, establecimientos);
        }

        // DELETE: api/Establecimientos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstablecimientos(long id)
        {
            var establecimientos = await _context.Establecimientos.FindAsync(id);
            if (establecimientos == null)
            {
                return NotFound();
            }

            _context.Establecimientos.Remove(establecimientos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstablecimientosExists(long id)
        {
            return _context.Establecimientos.Any(e => e.codigo == id);
        }
    }
}
