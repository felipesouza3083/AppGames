using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AppGames.App.Models.Plataforma;
using AppGames.Dados.Contracts;
using AppGames.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace AppGames.App.Controllers
{
    public class PlataformaController : Controller
    {
        private readonly IPlataformaRepository repository;

        public PlataformaController(IPlataformaRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult Index()
        {
            IList<PlataformaConsultaViewModel> lista = new List<PlataformaConsultaViewModel>();

            foreach(var plataforma in repository.FindAll())
            {
                PlataformaConsultaViewModel model = new PlataformaConsultaViewModel();
                model.IdPlataforma = plataforma.IdPlataforma;
                model.Nome = plataforma.Nome;

                lista.Add(model);
            }

            return View(lista);
        }

        [HttpGet]
        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult Salvar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(PlataformaCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                var plataforma = new Plataforma();

                plataforma.Nome = model.Nome;

                repository.Insert(plataforma);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult Editar(int id)
        {
            var plataforma = repository.FindById(id);

            var model = new PlataformaEdicaoViewModel();

            model.IdPlataforma = plataforma.IdPlataforma;
            model.Nome = plataforma.Nome;

            return View(model);
        }

        [HttpPost]
        public IActionResult Editar(PlataformaEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var plataforma = new Plataforma();

                plataforma.IdPlataforma = model.IdPlataforma;
                plataforma.Nome = model.Nome;

                repository.Update(plataforma);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            var plataforma = repository.FindById(id);

            repository.Delete(plataforma);

            return RedirectToAction("Index");
        }
    }
}