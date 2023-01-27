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
    public class CompaniasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CompaniasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Companias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Companias>>> GetCompanias()
        {
            return await _context.Companias.ToListAsync();
        }

        // GET: api/Companias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Companias>> GetCompanias(long id)
        {
            var companias = await _context.Companias.FindAsync(id);

            if (companias == null)
            {
                return NotFound();
            }

            return companias;
        }

        // PUT: api/Companias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanias(long id, Companias companias)
        {
            if (id != companias.codigo)
            {
                return BadRequest();
            }

            _context.Entry(companias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompaniasExists(id))
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

        // POST: api/Companias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Companias>> PostCompanias(Companias companias)
        {
            _context.Companias.Add(companias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompanias", new { id = companias.codigo }, companias);
        }

        // DELETE: api/Companias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanias(long id)
        {
            var companias = await _context.Companias.FindAsync(id);
            if (companias == null)
            {
                return NotFound();
            }

            _context.Companias.Remove(companias);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompaniasExists(long id)
        {
            return _context.Companias.Any(e => e.codigo == id);
        }
    }
}
