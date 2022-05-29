using System.Text.Json;
using ExamWebApplication.Contracts;
using ExamWebApplication.Models;

namespace HttpService;

public class TeamHttpService : ITeamService
{
    public async Task<ICollection<Team>> GetTeamAsync()
    {
        try
        {
            string content = await ServerAPI.getContent(Methods.Get, "ranking");
            ICollection<Team> teams = JsonSerializer.Deserialize<ICollection<Team>>(content, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            })!;
            return teams;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public Task<Team> GetTeamById(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<Team> AddTeam(Team team)
    {
        try
        {
            string content = await ServerAPI.getContent(Methods.Post, "teams", team);
            Team local = await JsonSerializer.Deserialize<Task<Team>>(content, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            })!;
            return local;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public Task DeleteTeam(string id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTeam(Team team)
    {
        throw new NotImplementedException();
    }
}