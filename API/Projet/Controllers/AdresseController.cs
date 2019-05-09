using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdresseController : ControllerBase
    {
        private readonly MyDbContext _context;

        public AdresseController(MyDbContext context)
        {
            _context = context;

            if (_context.Adresse.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Adresse.Add(
                    new Adresse{
                        numero = "2",
                        codePostal = "59200",
                        rue= "rue d'anzin",
                        ville= "Tourcoing"
                    });
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adresse>>> GetTodoItems()
        {
            return await _context.Adresse.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Adresse>> GetTodoItem(long id)
        {
            var adresse = await _context.Adresse.FindAsync(id);

            if (adresse == null)
            {
                return NotFound();
            }

            return adresse;
        }

        [HttpPost]
        public async Task<ActionResult<Adresse>> PostTodoItem(Adresse item)
        {
            _context.Adresse.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var adresse = await _context.Adresse.FindAsync(id);

            if (adresse == null)
            {
                return NotFound();
            }

            _context.Adresse.Remove(adresse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}