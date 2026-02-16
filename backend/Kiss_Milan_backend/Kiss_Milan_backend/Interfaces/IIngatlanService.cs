using Kiss_Milan_backend.Dtos;
using Kiss_Milan_backend.Models;

namespace Kiss_Milan_backend.Interfaces
{
    public interface IIngatlanService
    {
        List<IngatlanDto> Getingatlans();
        ingatlanok GetByIdIngatlanok(int id);
        void AddIngatlanok(ingatlanok ingat);
        bool RemoveIngatlan(int id);
    }
}
