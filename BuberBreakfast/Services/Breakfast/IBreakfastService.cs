using BuberBreakfast.Controllers;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfast;

public interface IBreakfastService
{
    void CreateBreakfast(BreakfastEntity breakfast);
    BreakfastEntity GetBreakfast(Guid id);
}