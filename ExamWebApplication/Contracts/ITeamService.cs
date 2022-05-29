using ExamWebApplication.Models;

namespace ExamWebApplication.Contracts;

public interface ITeamService
{
    public Task<ICollection<Team>> GetTeamAsync();
    public Task<Team> GetTeamById(string id);
    public Task<Team> AddTeam(Team team);
    public Task DeleteTeam(string id);
    public Task UpdateTeam(Team team);

}