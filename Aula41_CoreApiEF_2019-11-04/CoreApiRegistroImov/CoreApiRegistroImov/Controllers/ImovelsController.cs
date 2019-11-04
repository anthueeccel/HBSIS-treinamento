using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreApiRegistroImov.Models;

namespace CoreApiRegistroImov.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImovelsController : ControllerBase
    {
        private readonly ContextDatabase _context;

        public ImovelsController(ContextDatabase context)
        {
            _context = context;
        }

        // GET: api/Imovels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Imovel>>> Getimoveis()
        {
            return await _context.imoveis.ToListAsync();
        }

        // GET: api/Imovels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Imovel>> GetImovel(int id)
        {
            var imovel = await _context.imoveis.FindAsync(id);

            if (imovel == null)
            {
                return NotFound();
            }

            return imovel;
        }

        // PUT: api/Imovels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImovel(int id, Imovel imovel)
        {
            if (id != imovel.Id)
            {
                return BadRequest();
            }

            _context.Entry(imovel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImovelExists(id))
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

        // POST: api/Imovels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Imovel>> PostImovel(Imovel imovel)
        {
            _context.imoveis.Add(imovel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImovel", new { id = imovel.Id }, imovel);
        }

        // DELETE: api/Imovels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Imovel>> DeleteImovel(int id)
        {
            var imovel = await _context.imoveis.FindAsync(id);
            if (imovel == null)
            {
                return NotFound();
            }

            _context.imoveis.Remove(imovel);
            await _context.SaveChangesAsync();

            return imovel;
        }

        private bool ImovelExists(int id)
        {
            return _context.imoveis.Any(e => e.Id == id);
        }
    }
}
