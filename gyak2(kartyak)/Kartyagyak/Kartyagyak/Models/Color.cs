using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Kartyagyak.Models
{
    public class Color
    {
        [Key]
        public int ColorId {  get; set; }
        public string Name { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}
