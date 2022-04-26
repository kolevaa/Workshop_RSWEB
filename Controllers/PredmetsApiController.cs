#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Workshop_RSWEB.Data;
using Workshop_RSWEB.Models;

namespace Workshop_RSWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PredmetsApiController : ControllerBase
    {
        private readonly Workshop_RSWEBContext _context;

        public PredmetsApiController(Workshop_RSWEBContext context)
        {
            _context = context;
        }

        // GET: api/PredmetsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Predmet>>> GetPredmet()
        {
            return await _context.Predmet.ToListAsync();
        }

        // GET: api/PredmetsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Predmet>> GetPredmet(int id)
        {
            var predmet = await _context.Predmet.FindAsync(id);

            if (predmet == null)
            {
                return NotFound();
            }

            return predmet;
        }

        // PUT: api/PredmetsApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPredmet(int id, Predmet predmet)
        {
            if (id != predmet.Id)
            {
                return BadRequest();
            }

            _context.Entry(predmet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PredmetExists(id))
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

        // POST: api/PredmetsApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Predmet>> PostPredmet(Predmet predmet)
        {
            _context.Predmet.Add(predmet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPredmet", new { id = predmet.Id }, predmet);
        }

        // DELETE: api/PredmetsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePredmet(int id)
        {
            var predmet = await _context.Predmet.FindAsync(id);
            if (predmet == null)
            {
                return NotFound();
            }

            _context.Predmet.Remove(predmet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PredmetExists(int id)
        {
            return _context.Predmet.Any(e => e.Id == id);
        }
    }
}
