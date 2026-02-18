namespace Kartyagyak.Dto
{
    public class AddNewCardDto
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImgUrl { get; set; }
        public required int ColorId { get; set; }

    }
}

