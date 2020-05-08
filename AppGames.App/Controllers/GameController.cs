using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGames.Dados.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AppGames.App.Controllers
{
    public class GameController : Controller
    {
        private IGameRepository repository;

        public GameController(IGameRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}