using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Projet.Models;
using TodoApi.Models;

namespace Projet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InsertData();
            PrintData();
            CreateWebHostBuilder(args).Build().Run();
            
        }

        private static void InsertData()
        {
            using (var _context = new MyDbContext())
            {
                // Creates the database if not exists
                _context.Database.EnsureCreated();

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
                        Name = "tomate bio",
                        vendeur = v,
                        categorie = cat,
                        Prix = 10.10
                    });
                _context.SaveChanges();
            }
        }

        private static void PrintData()
        {
            // Gets and prints all books in database
            using (var context = new MyDbContext())
            {
                var pdt = context.Produit;
                foreach (var p in pdt)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"ID: {p.Id}");
                    data.AppendLine($"NAME: {p.Name}");
                    data.AppendLine($"PRIX: {p.Prix}");
                    Console.WriteLine(data.ToString());
                }
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
