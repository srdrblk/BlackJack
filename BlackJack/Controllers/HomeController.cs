using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlackJack.Models;
using Service.Interfaces;

namespace BlackJack.Controllers
{
    public class HomeController : Controller
    {
        IGameService gameService;

        public HomeController(IGameService _gameService)
        {
            gameService = _gameService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public void AddPlayer()
        {
            gameService.AddPlayer();
        }
        public void ClosePlayer(Guid Id)
        {
            gameService.ClosePlayer(Id);
        }
        public IActionResult Player(Guid Id)
        {
            var players = gameService.AddCard(Id);
            return View(players);
        }
        public IActionResult Casino(Guid Id)
        {
            var casino = gameService.AddCard(Id);
            return View(casino);
        }
        public IActionResult CreateGame()
        {
            var players = gameService.CreateGame();

            return View(players);
        }
        public void RestartGame()
        {
            gameService.RestartGame();
        }
        public void CloseGame()
        {
            gameService.CloseGame();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
