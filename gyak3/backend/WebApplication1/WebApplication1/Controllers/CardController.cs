using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.Interfaces;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/card")]
    [ApiController]
    public class CardController : ControllerBase
    {
        public readonly ICardService _context;

        public CardController (ICardService context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() { 
                
            var cards = _context.GetCards();
            return Ok(cards);
        }


        [HttpGet("{id}")]
        public IActionResult GetCard(int id) { 
            var card = _context.GetCardById(id);
            return card == null? NotFound() : Ok(card);
        }

        // POST api/<CardController>
        [HttpPost]

        public IActionResult AddCard(AddNewCard cardDto) {

            var card = new Card
            {
                ImgUrl = cardDto.ImgUrl,
                Description = cardDto.Description,
                Name = cardDto.Name,
                ColorId = cardDto.ColorId
            };
            _context.AddCard(card);
            return StatusCode(201,card);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var done = _context.DeleteCard(id);
            return done? Ok() : NotFound();
        }
    }
}
