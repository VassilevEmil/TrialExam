using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Team
{
    private ICollection<Player> players;
    
    [Key]
    public string TeamName { get; set; }
    
    [Required, MaxLength(50)]
    public string NameOfCoach { get; set; }
    public int Ranking { get; set; }
}