using Application.DAOInterfaces;
using ExamWebApplication.Contracts;
using ExamWebApplication.Models;

namespace Application.ServiceImpl;

public class PlayerServiceImpl : IPlayerService
{

    private ITeamDAO _teamDao;
    
    
    public Task<ICollection<Player>> GetPlayersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Player> GetPlayerById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Player> GetPlayer(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<Player> AddPlayer(Player player)
    {
        return await _teamDao.AddPlayer(player);
    }

    public Task DeletePlayer(string ShirtNumber)
    {
       return _teamDao.DeletePlayer(ShirtNumber);
    }

    public Task UpdatePlayer(Player player)
    {
        throw new NotImplementedException();
    }
}