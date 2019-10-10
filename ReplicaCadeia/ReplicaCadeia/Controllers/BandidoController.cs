using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap_Web.AspNet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _07_Fiap_Web.AspNet.Controllers
{
    public class BandidoController : Controller
    {
        private IBandidoRepository _bandidoRepository;
        private ICadeiaRepository _cadeiaRepository;

        public BandidoController(IBandidoRepository bandidoRepository,
            ICadeiaRepository cadeiaRepository)
        {
            _bandidoRepository = bandidoRepository;
            _cadeiaRepository = cadeiaRepository;
        }

        /*[HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }*/
    }
}