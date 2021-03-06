using Domain;

namespace Data;

public class GenreRepository : IRepository<Genre, int>
{
    private readonly ExamDbContext _dbContext;

    public GenreRepository(ExamDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Create(Genre data)
    {
        _dbContext.Genres.Add(data);
        _dbContext.SaveChanges();
    }

    public Genre Read(int key)
    {
        return _dbContext.Genres.Find(key)!;
    }

    public IEnumerable<Genre> ReadAll()
    {
        return _dbContext.Genres.ToList();
    }

    public void Update(Genre data)
    {
        _dbContext.Genres.Update(data);
        _dbContext.SaveChanges();
    }

    public void Delete(int key)
    {
        _dbContext.Genres.Remove(Read(key));
        _dbContext.SaveChanges();
    }
}