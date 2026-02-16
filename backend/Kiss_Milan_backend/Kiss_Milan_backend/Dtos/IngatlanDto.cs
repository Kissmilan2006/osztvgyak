namespace Kiss_Milan_backend.Dtos
{
    public class IngatlanDto
    {
        public int id { get; set; }
        public string kategoria { get; set; } 
        public string? leiras { get; set; }
        public DateTime hirdetesDatuma { get; set; }
        public bool tehermentes { get; set; }
        public int ar { get; set; }
        public string? kepUrl { get; set; }
    }
}
