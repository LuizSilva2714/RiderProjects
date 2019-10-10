using _07_Fiap_Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace _07_Fiap_Web.AspNet.Repositories
{
    public interface ICadeiaRepository
    {
        void Cadastrar(Cadeia cadeia);
        void Atualizar(Cadeia cadeia);
        void Remover(int codigo);
        IList<Cadeia> Listar();
        Cadeia BuscarPorCodigo(int codigo);
        void Salvar();
        IList<Cadeia> BuscarPor(
                Expression<Func<Cadeia, bool>> filtro);
    }
}
