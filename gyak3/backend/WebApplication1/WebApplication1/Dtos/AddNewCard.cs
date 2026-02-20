namespace WebApplication1.Dtos
{
    public class AddNewCard
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public string? ImgUrl { get; set; }
        public required int ColorId { get; set; }

    }
}
