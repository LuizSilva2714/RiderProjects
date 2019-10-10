using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap_Web.AspNet.Models
{
    public class Cadeia
    {
        public int CadeiaId { get; set; }
        public string Nome { get; set; }
        public Nivel Nivel { get; set; }
        public int Capacidade { get; set; }

        public IList<Bandido> Bandidos { get; set; }
    }
}


