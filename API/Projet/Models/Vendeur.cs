using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Vendeur
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

       [ForeignKey("AdresseForeignKey")]
        public Adresse adresse { get; set; }

    }
}