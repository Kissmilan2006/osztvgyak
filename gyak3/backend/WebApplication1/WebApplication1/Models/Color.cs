using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Card> cards { get; set; }
    }
}
