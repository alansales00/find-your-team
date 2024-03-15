using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("Game")]
    public class GameController : ControllerBase
    {
        [HttpGet("/all")]
        public IActionResult AllGames()
        {
            using var db = new MyAppContext();
            var gameList = db.Games.ToList();
            return Ok(gameList);
        }

        [HttpGet("{id}")]
        public IActionResult GetGame(int id)
        {
            using var db = new MyAppContext();
            var game = db.Games.Where(x => x.Id == id);
            return Ok(game);
        }

        [HttpPost]
        public IActionResult CreateGame(Game game)
        {
            using var db = new MyAppContext();
            var newGame = db.Games.Add(game);
            db.SaveChanges();
            return Ok(game);
        }

        [HttpPut("{id}")]
        public IActionResult EditGame(int id, Game game)
        {
            using var db = new MyAppContext();
            var oldGame = db.Games.FirstOrDefault(x => x.Id == id);
            oldGame = game;
            db.SaveChanges();
            return Ok();

        }

        [HttpPatch("{id}")]
        public IActionResult EditGameProperties(int id, Game game)
        {
            using var db = new MyAppContext();
            var oldGame = db.Games.FirstOrDefault(x => x.Id == id);
            oldGame.Local = game.Local;
            oldGame.Slots = game.Slots;
            oldGame.Level = game.Level;
            oldGame.Category = game.Category;
            db.SaveChanges();
            return Ok();
        }


    }
}
