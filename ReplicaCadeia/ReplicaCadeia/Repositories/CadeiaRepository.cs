using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using _07_Fiap_Web.AspNet.Models;
using _07_Fiap_Web.AspNet.Persistences;

namespace _07_Fiap_Web.AspNet.Repositories
{
    public class CadeiaRepository : ICadeiaRepository
    {
        private JusticaContext _context;

        public CadeiaRepository(JusticaContext context)
        {
            _context = context;
        }

        public void Atualizar(Cadeia cadeia)
        {
            _context.Cadeias.Update(cadeia);
        }

        public IList<Cadeia> BuscarPor(Expression<Func<Cadeia, bool>> filtro)
        {
            return _context.Cadeias.Where(filtro).ToList();
        }

        public Cadeia BuscarPorCodigo(int codigo)
        {
            return _context.Cadeias.Find(codigo);
        }

        public void Cadastrar(Cadeia cadeia)
        {
            _context.Cadeias.Add(cadeia);
        }

        public IList<Cadeia> Listar()
        {
            return _context.Cadeias.ToList();
        }

        public void Remover(int codigo)
        {
            var cadeia = _context.Cadeias.Find(codigo);
            _context.Cadeias.Remove(cadeia);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
