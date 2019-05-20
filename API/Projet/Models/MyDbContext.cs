
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace Projet.Models
{
    public class MyDbContext : DbContext 
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
              => optionsBuilder.UseNpgsql("Host=5.135.156.172;Database=carottesrapee;Username=patatedouce;Password=p~3ETR!");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vendeur>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.Id);
            });


            modelBuilder.Entity<Adresse>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.numero).IsRequired();
                entity.Property(e => e.ville).IsRequired();
                entity.Property(e => e.rue).IsRequired();
            });
        }

        public DbSet<Adresse> Adresse { get; set; }
        public DbSet<Vendeur> Vendeur { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Produit> Produit { get; set; }

        public DbSet<Notation> notation { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }
    }
}
