using System.ComponentModel.DataAnnotations;

namespace Kiss_Milan_backend.Models
{
    public class kategoriak
    {
       [Key]
       public int Id { get; set; }
       public string? Name { get; set; } 
    }
}
