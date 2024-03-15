using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("Players")]
    public class PlayerController : Controller
    {
        [HttpPost]
        public IActionResult CreatePlayer(Player player)
        {
            using var db = new MyAppContext();
            var newGame = db.Players.Add(player);
            db.SaveChanges();
            return Ok();
        }
    }
}
