using System.ComponentModel.DataAnnotations;

namespace ExamWebApplication.Models;

public class Player
{
    [Required, MaxLength(50)]
    public string Name { get; set; }
    
    [Key, MinLength(1), MaxLength(99)]
    public int ShirtNumber { get; set; }
    
    public decimal Salary { get; set; }
    public int GoalsThisSeason { get; set; }
    
    [Required]
    public string Position { get; set; }
}