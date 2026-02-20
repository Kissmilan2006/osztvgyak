using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class CardService : ICardService
    {
        public readonly AppDbContext _context;

        public CardService(AppDbContext context)
        {
            _context = context;
        }
        public void AddCard(Card card)
        {
          _context.Add(card);
          _context.SaveChanges();
        }

        public bool DeleteCard(int id)
        {
          var card = _context.Cards.FirstOrDefault(x => x.Id == id);
            if (card != null) { 
            _context.Cards.Remove(card);
            _context.SaveChanges();
            return true;
            }
            return false;
        }

        public Card GetCardById(int id)
        {
            var card = _context.Cards.FirstOrDefault(x =>x.Id == id);
            if (card != null) { 
                return card;
            }
            throw new Exception("nincs ilyen");
        }

        public List<Card> GetCards()
        {
          return _context.Cards.ToList();
        }

        public List<Color> GetColors()
        {
            return _context.Colors.ToList();
        }
    }
}
