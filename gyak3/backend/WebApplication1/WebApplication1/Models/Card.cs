using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public string? ImgUrl { get; set; }
        public required int ColorId { get; set; }

        public Color? Color { get; set; }

    }
}
