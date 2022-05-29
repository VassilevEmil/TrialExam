using Application.DAOInterfaces;
using ExamWebApplication.Models;

namespace ExamWebApplication.DataAccess.DAOImpl;

public class TeamDaoImpl : ITeamDAO
{

    private FileContext _context;

    public TeamDaoImpl(FileContext context)
    {
        _context = context;
    }

    public async Task<Player> AddPlayer(Player player)
    {
        if (_context.Team.Players.Any(t => t.ShirtNumber.Equals(player.ShirtNumber)))
        {
            throw new Exception("shirt number occupied");
        }
        else
        {
            _context.Team.Players.Add(player);
            _context.SaveChanges();
            return player;
        }
    }

    public async Task DeletePlayer(string id)
    {
        Player toDelete = _context.Team.Players.First(t => t.ShirtNumber.Equals(id));
        _context.Team.Players.Remove(toDelete);
        _context.SaveChanges();
    }

    public Task<ICollection<Team>> GetTeamAsync()
    {
        return null;
    }

    public Task<Team> AddTeam(Team team)
    {
        return null;
    }
}