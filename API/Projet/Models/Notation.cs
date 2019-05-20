using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Notation
    {
        public long Id { get; set; }

        [ForeignKey("ForeignKey")]
        public Utilisateur Utilisateur { get; set; }

        [ForeignKey("ProduitForeignKey")]
        public Produit produit { get; set; }

        public int note { set { Id = integrityFunction(value) ? value : 0; } get { return this.note; } }

        private bool integrityFunction (int n)
        {
            return (n < 5 && n > 0);
        }
    }
}