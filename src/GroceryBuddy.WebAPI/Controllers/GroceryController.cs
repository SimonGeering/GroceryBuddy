using Microsoft.AspNetCore.Mvc;

using GroceryBuddy.WebAPI.Domain;

namespace GroceryBuddy.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GroceryController : ControllerBase
{
    private readonly IGroceryService _groceryService;
    private readonly ILogger<GroceryController> _logger;

    public GroceryController(
        IGroceryService groceryService,
        ILogger<GroceryController> logger)
    {
        _groceryService = groceryService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Grocery>>> Get()
        => Ok(await _groceryService.GetGroceryList());

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Grocery>> GetById([FromRoute] string id)
        => Ok(await _groceryService.GetGroceryById(id));

    [HttpPost]
    public async Task<ActionResult<Grocery>> Post([FromBody] Grocery grocery)
    {
        var response = await _groceryService.Create(grocery);
        return CreatedAtRoute(nameof(GetById), response);
    }

    [HttpPut]
    public async Task<ActionResult<IEnumerable<Grocery>>> Put([FromBody] Grocery grocery)
        => Ok(await _groceryService.Update(grocery));

    [HttpDelete]
    public async Task<ActionResult<IEnumerable<Grocery>>> Delete([FromRoute] string id)
    {
        await _groceryService.DeleteGroceryById(id);
        return NoContent();
    }
}
