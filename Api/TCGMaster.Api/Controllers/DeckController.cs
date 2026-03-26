using Microsoft.AspNetCore.Mvc;
using TCGMaster.Application.Services;

namespace TCGMaster.Api.Controllers;

[ApiController]
[Route("decks")]
public class DeckController : ControllerBase
{
    private readonly DeckService _service;

    public DeckController(DeckService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(string name)
    {
        var deck = await _service.CreateDeckAsync(name);
        return Ok(deck);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var decks =  await _service.GetDecksAsync();
        return Ok(decks);
    }

    [HttpGet("GetByID")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var deck = await _service.GetDeckByIdAsync(id);
        return Ok(deck);
    }
}