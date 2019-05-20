using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Utilisateur
    {
        public long Id { get; set; }

        public string name { get; set; }

        [ForeignKey("adresseForeignKey")]
        public Adresse adresse { get; set; }
       

    }
}