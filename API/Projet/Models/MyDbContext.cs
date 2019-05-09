using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace Projet.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Adresse> Adresse { get; set; }
        public DbSet<Vendeur> Vendeur { get; set; }
        public DbSet<Categorie> Categorie { get; set; }

        public DbSet<Produit> Produit { get; set; }
    }
}
