using ExamWebApplication.Models;

namespace ExamWebApplication.Contracts;

public interface IPlayerService
{
    public Task<ICollection<Player>> GetPlayersAsync();
    public Task<Player> GetPlayerById(string id);
    public Task<Player> GetPlayer(string name);
    public Task<Player> AddPlayer(Player player);
    public Task DeletePlayer(string ShirtNumber);
    public Task UpdatePlayer(Player player);
}