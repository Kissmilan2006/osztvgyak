using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ICardService
    {
        List<Card> GetCards();
        List<Color> GetColors();
        Card GetCardById(int id);
        void AddCard(Card card);
        bool DeleteCard(int id);
    }
}
