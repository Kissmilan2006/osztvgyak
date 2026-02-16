using Kiss_Milan_backend.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kiss_Milan_backend.Dtos
{
    public class AddNewIngatlanDto
    {
        public required int kategoria { get; set; }  
        public required string leiras { get; set; }
        public DateTime? hirdetesDatuma { get; set; }
        public required bool tehermentes { get; set; }
        public required int ar { get; set; }
        public required string kepUrl { get; set; }
    }
}
