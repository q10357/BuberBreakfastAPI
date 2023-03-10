using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfast;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, BreakfastEntity> _breakfasts = new();
    public void CreateBreakfast(BreakfastEntity breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    public BreakfastEntity GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }
}