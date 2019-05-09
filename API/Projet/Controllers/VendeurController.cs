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
    public class VendeurController : ControllerBase
    {
        private readonly MyDbContext _context;

        public VendeurController(MyDbContext context)
        {
            _context = context;

            if (_context.Vendeur.Count() == 0)
            {
                Adresse adr = new Adresse {
                    numero = "2",
                    codePostal = "59200",
                    rue = "rue d'anzin",
                    ville = "Tourcoing"
                };

                _context.Adresse.Add(adr);
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Vendeur.Add(
                    new Vendeur {
                        adresse = adr,
                        Name = "Vendeur test",
                        Description = "ceuci est un vendeur autogenerer"
                });

                /*adresse = {
                    numero = "2",
                    codePostal = "59200",
                    rue = "rue d'anzin",
                    ville = "Tourcoing"
                }*/
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendeur>>> GetTodoItems()
        {
            return await _context.Vendeur.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendeur>> GetTodoItem(long id)
        {
            var item = await _context.Vendeur.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<Vendeur>> PostTodoItem(Vendeur item)
        {
            _context.Vendeur.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var item = await _context.Vendeur.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Vendeur.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}