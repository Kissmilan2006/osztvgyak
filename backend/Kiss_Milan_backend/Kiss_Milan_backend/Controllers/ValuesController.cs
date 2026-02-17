using Kiss_Milan_backend.Dtos;
using Kiss_Milan_backend.Interfaces;
using Kiss_Milan_backend.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kiss_Milan_backend.Controllers
{
    [Route("api/ingatlan")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IIngatlanService _ingatlanService;
        

        public ValuesController(IIngatlanService ingatlanService)
        {
            _ingatlanService = ingatlanService;
        }

        [HttpGet]
        public IActionResult Get() { 
            var ingatlanok = _ingatlanService.Getingatlans();
            
            return StatusCode(200, ingatlanok);
        }
        [HttpGet("kategoriak")]
        public IActionResult GetKategoriak()
        {
            var kategoriak = _ingatlanService.GetKategoriaks();
            return Ok(kategoriak);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ingatlan = _ingatlanService.GetByIdIngatlanok(id);
            return ingatlan is null ? NotFound("Nincs ilyen ingatlan") : Ok(ingatlan);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult AddNewIngatlan(AddNewIngatlanDto ingatlansDto) 
        {
            ingatlanok ingatlan = new ingatlanok
            {

                kategoria = ingatlansDto.kategoria,
                leiras = ingatlansDto.leiras,
                hirdetesDatuma = ingatlansDto.hirdetesDatuma ?? default,
                tehermentes = ingatlansDto.tehermentes,
                ar = ingatlansDto.ar,
                kepUrl = ingatlansDto.kepUrl,
            };
            _ingatlanService.AddIngatlanok(ingatlan);
            return StatusCode(201, ingatlan.id);
        }


        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ingatlan = _ingatlanService.RemoveIngatlan(id);
            return ingatlan? NoContent() : NotFound("Az ingatlan nem létezik");
        }
    }
}
