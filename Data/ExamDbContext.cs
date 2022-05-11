using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class ExamDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Game> Games { get; set; }
    
    public ExamDbContext(DbContextOptions options) : base(options)
    {
    }
}