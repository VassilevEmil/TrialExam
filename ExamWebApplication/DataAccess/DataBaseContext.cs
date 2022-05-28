using ExamWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamWebApplication.DataAccess;

public class DataBaseContext : DbContext
{
    public DbSet<Player> Players { get; set; } = null!;
    public DbSet<Team> Teams { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source = ..\ExamWebApplication\DataBase.db");
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>().HasKey(team => team.TeamName);
        modelBuilder.Entity<Player>().HasKey(player => player.ShirtNumber);
    }
}