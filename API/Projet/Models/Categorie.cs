using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Categorie
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Famille { get; set; }

    }

 }