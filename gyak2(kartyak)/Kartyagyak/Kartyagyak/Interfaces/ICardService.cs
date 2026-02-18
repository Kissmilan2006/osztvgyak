using Kartyagyak.Models;

namespace Kartyagyak.Interfaces
{
    public interface ICardService
    {
        List<Card> GetCards();
        Card GetCard(int id);
        bool DeleteCard(int id);
        void AddCard(Card card);
    }
}
