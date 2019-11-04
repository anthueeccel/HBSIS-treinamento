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
    public class ProprietariosController : ControllerBase
    {
        private readonly ContextDatabase _context;

        public ProprietariosController(ContextDatabase context)
        {
            _context = context;
        }

        // GET: api/Proprietarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proprietario>>> Getproprietarios()
        {
            return await _context.proprietarios.ToListAsync();
        }

        // GET: api/Proprietarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proprietario>> GetProprietario(int id)
        {
            var proprietario = await _context.proprietarios.FindAsync(id);

            if (proprietario == null)
            {
                return NotFound();
            }

            return proprietario;
        }

        // PUT: api/Proprietarios/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProprietario(int id, Proprietario proprietario)
        {
            if (id != proprietario.Id)
            {
                return BadRequest();
            }

            _context.Entry(proprietario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProprietarioExists(id))
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

        // POST: api/Proprietarios
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Proprietario>> PostProprietario(Proprietario proprietario)
        {
            _context.proprietarios.Add(proprietario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProprietario", new { id = proprietario.Id }, proprietario);
        }

        // DELETE: api/Proprietarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Proprietario>> DeleteProprietario(int id)
        {
            var proprietario = await _context.proprietarios.FindAsync(id);
            if (proprietario == null)
            {
                return NotFound();
            }

            _context.proprietarios.Remove(proprietario);
            await _context.SaveChangesAsync();

            return proprietario;
        }

        private bool ProprietarioExists(int id)
        {
            return _context.proprietarios.Any(e => e.Id == id);
        }
    }
}
