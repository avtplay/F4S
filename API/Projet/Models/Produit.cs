using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Produit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("vendeurForeignKey")]
        public Vendeur vendeur { get; set; }
        [ForeignKey("categorieForeignKey")]
        public Categorie categorie { get; set; }
        public double Prix { get; set; }

    }
}