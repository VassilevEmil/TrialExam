using ExamWebApplication.Contracts;
using ExamWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace TeamWebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class TeamController : ControllerBase
{

    private ITeamService _teamService;

    public TeamController(ITeamService teamService)
    {
        _teamService = teamService;
    }

    [HttpPost]

    public async Task<ActionResult<Team>> AddTeam([FromBody] Team team)
    {
        try
        {
            Team added = await _teamService.AddTeam(team);
            return Created($"/teams/{team.TeamName}", team);
        }
        catch(Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    [Route("test/ {ranking}/{teamName}")]

    public async Task<ActionResult<ICollection<Team>>> GetAll([FromQuery]int ranking, [FromQuery] string teamName)
    {
        try
        {
            ICollection<Team> teams = await _teamService.GetTeamAsync();
            return Ok(teams);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
}