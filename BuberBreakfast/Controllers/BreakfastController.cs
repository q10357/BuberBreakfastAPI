namespace BuberBreakfast.Controllers;

using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;

[ApiController]
public class BreakfastController: ControllerBase
{
    [HttpPost("/breakfasts")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpGet("/breakfasts/{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/breakfasts/{id:guid}")]
    public IActionResult UpdateBreakfast(UpsertBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("/breakfasts/{id:guid}")]
    public IActionResult DeleteBreakfast(CreateBreakfastRequest request)
    {
        return Ok();
    }
}

