using Application.DAOInterfaces;
using ExamWebApplication.Contracts;
using ExamWebApplication.DataAccess;
using ExamWebApplication.Models;

namespace Application.ServiceImpl;

public class TeamServiceImpl : ITeamService
{

    private ITeamDAO _teamDao;

    public TeamServiceImpl(ITeamDAO _teamDao)
    {
        this._teamDao = _teamDao;
    }

    public async Task<ICollection<Team>> GetTeamAsync()
    {
        //return await _context.
        return await _teamDao.GetTeamAsync();
    }

    public Task<Team> GetTeamById(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<Team> AddTeam(Team team)
    {
        return await _teamDao.AddTeam(team);
    }

    public Task DeleteTeam(string id)
    {
        return null;
    }

    public Task UpdateTeam(Team team)
    {
        return null;
    }
}