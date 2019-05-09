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
    public class CategorieController : ControllerBase
    {
        private readonly MyDbContext _context;

        public CategorieController(MyDbContext context)
        {
            _context = context;

            if (_context.Categorie.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Categorie.Add(
                    new Categorie
                    {
                        Name="Tomates",
                        Famille="Fruit",
                    });
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categorie>>> GetTodoItems()
        {
            return await _context.Categorie.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categorie>> GetTodoItem(long id)
        {
            var item = await _context.Categorie.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<Categorie>> PostTodoItem(Categorie item)
        {
            _context.Categorie.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var item = await _context.Categorie.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Categorie.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}