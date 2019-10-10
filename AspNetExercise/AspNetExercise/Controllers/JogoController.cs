using System.Collections.Generic;
using System.Linq;
using AspNetExercise.Models;
using AspNetExercise.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetExercise.Controllers
{
    public class JogoController : Controller
    {
        private GamesContext _context;

        public JogoController(GamesContext context)
        {
            _context = context;
        }
        // GET
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Jogos.ToList());
        }

        [HttpPost]
        public IActionResult Disponibilizar(int id)
        {
            Jogo jogo = _context.Jogos.Find(id);
            jogo.Disponivel = true;
            _context.Jogos.Attach(jogo).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "O jogo agora está disponível!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Excluir(int codigo)
        {
            Jogo jogo = _context.Jogos.Find(codigo);
            _context.Jogos.Remove(jogo);
            _context.SaveChanges();
            TempData["msg"] = "Jogo excluído com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            return View(_context.Jogos.Find(id));
        }

        [HttpPost]
        public IActionResult Editar(Jogo jogo)
        {
            _context.Jogos.Attach(jogo).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Buscar(string nomeBusca)
        {
            List<Jogo> jogos = _context.Jogos.Where
                (j => j.Nome.ToLower().Contains(nomeBusca) || string.IsNullOrEmpty(nomeBusca)).ToList();
            if (!string.IsNullOrEmpty(nomeBusca))
            {
                TempData["msg"] = "Buscando jogos cujo nome contém: " + nomeBusca;
            }
            else
            {
                TempData["msg"] = "Buscando todos os jogos";
            }
             
            return View("Listar", jogos);

        }
        
        
    }
}