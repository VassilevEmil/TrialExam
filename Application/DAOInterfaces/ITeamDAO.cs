using ExamWebApplication.Models;

namespace Application.DAOInterfaces;

public interface ITeamDAO
{
    public Task<Player> AddPlayer(Player player);
    public Task DeletePlayer(string id);

    public Task<ICollection<Team>> GetTeamAsync();
    public Task<Team> AddTeam(Team team);
}