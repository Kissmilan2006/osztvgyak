using Kartyagyak.Dto;
using Kartyagyak.Interfaces;
using Kartyagyak.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kartyagyak.Controllers
{
    [Route("api/card")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet]
        public IActionResult GetAll() 
            {
                var cards = _cardService.GetCards();
                return Ok(cards);
            }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
                var card = _cardService.GetCard(id);
                return card != null ? Ok(card) : NotFound();
         }

            // POST api/<CardController>
            [HttpPost]
            public IActionResult Add(AddNewCardDto dto)
            {
            Card card = new Card
            {
                Name = dto.Name,
                ImgUrl = dto.ImgUrl,
                ColorId = dto.ColorId,
                Description = dto.Description,
            };
            _cardService.AddCard(card);
            return Ok(card);
            }


            // DELETE api/<CardController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
         var done = _cardService.DeleteCard(id);
         return done== true ? Ok() : NotFound(); 
        }
        
    }
}
