using Kartyagyak.Data;
using Kartyagyak.Interfaces;
using Kartyagyak.Models;

namespace Kartyagyak.Services
{
    public class CardService : ICardService
    {
        private readonly AppDbContext _context;

        public CardService(AppDbContext appDbContext) { 
        
            _context = appDbContext;
        }
        public void AddCard(Card card)
        {
           _context.Cards.Add(card);
           _context.SaveChanges();
         }

        public bool DeleteCard(int id)
        {
            var card = _context.Cards.FirstOrDefault(x => x.Id == id);
            if (card == null) return false;

            _context.Cards.Remove(card);
            _context.SaveChanges();
            return true;
        }

        public Card GetCard(int id)
        {
            return _context.Cards.FirstOrDefault(x => x.Id == id);



        }

        public List<Card> GetCards()
        {
            return _context.Cards.ToList();
        }
    }
}
