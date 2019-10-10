using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap_Web.AspNet.Models;
using _07_Fiap_Web.AspNet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _07_Fiap_Web.AspNet.Controllers
{
    public class CadeiaController : Controller
    {
        private ICadeiaRepository _repository;

        public CadeiaController(ICadeiaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_repository.Listar());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cadeia cadeia)
        {
            _repository.Cadastrar(cadeia);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}