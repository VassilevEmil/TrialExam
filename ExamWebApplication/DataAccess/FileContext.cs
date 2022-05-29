using System.Text.Json;
using ExamWebApplication.Models;

namespace ExamWebApplication.DataAccess;

public class FileContext
{
    
    private string TeamFilePath = "team.json";
    
    private Team? team;

    public Team Team
    {
        get
        {
            if (team == null)
            {
                loadData();
            }

            return team!;
        }
    }

    private void Seed()
    {
        team = new Team();
        Player[] players =
        {
            new Player()
            {
                Name = "allan", Position = "forward", ShirtNumber = 10, GoalsThisSeason = 16, Salary = 222
            },
            new Player()
            {
                Name = "Emil", Position = "wing-back", ShirtNumber = 3, GoalsThisSeason = 7, Salary = 222
            }

        };

        Team[] tm =
        {
            new Team()
            {
                TeamName = "Levski", NameOfCoach = "Klop", Ranking = 3
            }
        };

        team.Players = players.ToList();

    }

    public void SaveChanges()
    {
        string serialize = JsonSerializer.Serialize(Team);
        File.WriteAllText(TeamFilePath, serialize);
    }

    private void loadData()
    {
        string content = File.ReadAllText(TeamFilePath);
        team = JsonSerializer.Deserialize<Team>(content);
    }
}