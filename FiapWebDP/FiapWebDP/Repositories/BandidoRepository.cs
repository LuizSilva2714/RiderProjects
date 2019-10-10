using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap_Web.AspNet.Models;
using _07_Fiap_Web.AspNet.Persistences;

namespace _07_Fiap_Web.AspNet.Repositories
{
    public class BandidoRepository : IBandidoRepository
    {
        private JusticaContext _context;

        public BandidoRepository(JusticaContext context)
        {
            _context = context;
        }

        public void Cadastrar(Bandido bandido)
        {
            _context.Bandidos.Add(bandido);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
