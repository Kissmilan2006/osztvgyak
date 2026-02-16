using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kiss_Milan_backend.Models
{
    public class ingatlanok
    {
        [Key]
        public int id { get; set; }
        public required kategoriak kategoraOBJ { get; set; }
        [ForeignKey("kategoraOBJ")]
        public int  kategoria {  get; set; }
        public string leiras { get; set; }
        public DateTime hirdetesDatuma { get; set; }
        public bool tehermentes { get; set; }
        public int ar { get; set; }
        public string kepUrl { get; set; }
    }
}
