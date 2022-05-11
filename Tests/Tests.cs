using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Tests;

public class Tests
{
    private ExamDbContext _dbContext;
    private GameRepository _gameRepository;
    
    [SetUp]
    public void Setup()
    {
        var builder = new DbContextOptionsBuilder();
        builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

        _dbContext = new ExamDbContext(builder.Options);
        _gameRepository = new GameRepository(_dbContext);
    }

    [Test]
    public void CreateGame_ShouldReturnOK()
    {
        _gameRepository.Create(new Game{Name = "Forza"});
        var game = _gameRepository.Read(1);
        
        Assert.NotNull(game);
    }

    [Test]
    public void ReadGame_ShouldReturnOK()
    {
        _gameRepository.Create(new Game{Name = "Forza"});
        var game = _gameRepository.Read(1);
        
        Assert.NotNull(game);
    }
    
    [Test]
    public void ReadAllGames_ShouldReturnOK()
    {
        _gameRepository.Create(new Game{Name = "Forza"});
        var game = _gameRepository.ReadAll();
        
        Assert.NotNull(game);
    }
    
    [Test]
    public void UpdateGame_ShouldReturnOK()
    {
        _gameRepository.Create(new Game{Name = "Forza"});
        var game = _gameRepository.Read(1);
        game.Name = "Horizon";
        _gameRepository.Update(game);
        game = _gameRepository.Read(1);
        Assert.AreEqual(game.Name, "Horizon");
    }
    
    [Test]
    public void DeleteGame_ShouldReturnOK()
    {
        _gameRepository.Create(new Game{Name = "Forza"});
        _gameRepository.Delete(1);
        var game = _gameRepository.Read(1);
        Assert.IsNull(game);
    }
}