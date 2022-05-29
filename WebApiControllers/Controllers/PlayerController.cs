using ExamWebApplication.Contracts;
using ExamWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace TeamWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{

    public IPlayerService _PlayerService;

    public PlayerController(IPlayerService playerService)
    {
        _PlayerService = playerService;
    }

    [HttpPost]

    public async Task<ActionResult<Player>> AddPlayer([FromBody] Player player)
    {
        try
        {
            Player added = await _PlayerService.AddPlayer(player);
            return Created($"/player/{added.Name}", added);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpDelete]
    [Route("{shirtNumber}")]

    public async Task<ActionResult<ICollection<Player>>> DeleteByShirtNumber([FromRoute] string shirtNumber)
    {
        try
        {
            await _PlayerService.DeletePlayer(shirtNumber);
            return Ok("Player deleted" + shirtNumber);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

}