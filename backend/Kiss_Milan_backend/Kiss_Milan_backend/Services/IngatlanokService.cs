using Kiss_Milan_backend.Data;
using Kiss_Milan_backend.Dtos;
using Kiss_Milan_backend.Interfaces;
using Kiss_Milan_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Kiss_Milan_backend.Service
{
    public class IngatlanokService : IIngatlanService
    {
        private readonly AppDbContext _context;

        public IngatlanokService(AppDbContext context)
        {
            _context = context;
        }

        public void AddIngatlanok(ingatlanok ingat)
        {
           _context.ingatlanoks.Add(ingat);
           _context.SaveChanges();
        }

        public ingatlanok GetByIdIngatlanok(int id)
        {
            return _context.ingatlanoks.FirstOrDefault(i => i.id == id);
        }

        public List<IngatlanDto> Getingatlans()
        {
            return _context.ingatlanoks
                .Include(i => i.Kategoria)
                .Select(i => new IngatlanDto
                {
                     id = i.id,
                     kategoria = i.Kategoria!.Name,   // ⭐ név
                     leiras = i.leiras,
                     hirdetesDatuma = i.hirdetesDatuma,
                     tehermentes = i.tehermentes,
                     ar = i.ar,
                     kepUrl = i.kepUrl
                })
                .ToList();
        }

        public bool RemoveIngatlan(int id)
        {
            var ingatlan = _context.ingatlanoks.FirstOrDefault(i => i.id == id);
            if ( ingatlan == null ) return false;

            _context.ingatlanoks.Remove(ingatlan);
            _context.SaveChanges();
            return true;

            
        }
    }
}
