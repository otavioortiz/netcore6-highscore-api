namespace HighscoreApi.Context;

using HighscoreApi.Models;
using Microsoft.EntityFrameworkCore;

public class SqliteDataContext:DbContext
{
    public SqliteDataContext(DbContextOptions<SqliteDataContext> options) : base(options){}

    public DbSet<ScoreItem> ?Scores { get; set; }

}