using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kartyagyak.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImgUrl    { get; set; }
        public required int ColorId {  get; set; }
        public Color? Color { get; set; }


        
    }
}
