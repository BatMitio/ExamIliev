using Domain;

namespace Data;

public class GameRepository : IRepository<Game, int>
{
    private readonly ExamDbContext _dbContext;

    public GameRepository(ExamDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Create(Game data)
    {
        _dbContext.Games.Add(data);
        _dbContext.SaveChanges();
    }

    public Game Read(int key)
    {
        return _dbContext.Games.Find(key)!;
    }

    public IEnumerable<Game> ReadAll()
    {
        return _dbContext.Games.ToList();
    }

    public void Update(Game data)
    {
        _dbContext.Games.Update(data);
        _dbContext.SaveChanges();
    }

    public void Delete(int key)
    {
        _dbContext.Games.Remove(Read(key));
        _dbContext.SaveChanges();
    }
}