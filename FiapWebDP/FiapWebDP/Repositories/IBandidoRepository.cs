using _07_Fiap_Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap_Web.AspNet.Repositories
{
    public interface IBandidoRepository
    {
        void Cadastrar(Bandido bandido);
        void Salvar();
    }
}
