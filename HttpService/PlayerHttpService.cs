using System.Text.Json;
using ExamWebApplication.Contracts;
using ExamWebApplication.Models;

namespace HttpService;

public class PlayerHttpService : IPlayerService
{
    public async Task<ICollection<Player>> GetPlayersAsync()
    {
        
            throw new NotImplementedException();
    }

    public async Task<Player> GetPlayerById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Player> GetPlayer(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<Player> AddPlayer(Player player)
    {
        try
        {
            string content = await ServerAPI.getContent(Methods.Post, "/player", player);
            Player local = JsonSerializer.Deserialize<Player>(content, new JsonSerializerOptions()
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

    public async Task DeletePlayer(string ShirtNumber)
    {
        try
        {
            string content = await ServerAPI.getContent(Methods.Delete, $"shirtNumber/{ShirtNumber}");
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public Task UpdatePlayer(Player player)
    {
        throw new NotImplementedException();
    }
}