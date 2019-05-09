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
    public class ProduitController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ProduitController(MyDbContext context)
        {
            _context = context;

            if (_context.Categorie.Count() == 0)
            {

               Categorie cat = new Categorie
               {
                   Name = "Tomates",
                   Famille = "Fruit",
               };
                _context.Categorie.Add(cat);

                Adresse adr = new Adresse
                {
                    numero = "2",
                    codePostal = "59200",
                    rue = "rue d'anzin",
                    ville = "Tourcoing"
                };

                _context.Adresse.Add(adr);
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                Vendeur v = new Vendeur
                {
                    adresse = adr,
                    Name = "Vendeur test",
                    Description = "ceuci est un vendeur autogenerer"
                };
                _context.Vendeur.Add(v);

                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Produit.Add(
                    new Produit
                    {
                        Description = "ceci sont des des tomates bio de chez vendeur test",
                        Name ="tomate bio",
                        vendeur = v,
                        categorie = cat,
                        Prix = 10.10
                    });
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produit>>> GetTodoItems()
        {
            return await _context.Produit.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produit>> GetTodoItem(long id)
        {
            var item = await _context.Produit.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<Produit>> PostTodoItem(Produit item)
        {
            _context.Produit.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var item = await _context.Produit.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Produit.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}