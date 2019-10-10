using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap_Web.AspNet.Models
{
    public class Bandido
    {
        public int BandidoId { get; set; }
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public string Capivara { get; set; }
        public string Vulgo { get; set; }
        public bool ReuPrimario { get; set; }

        public Cadeia Cadeia { get; set; }
        public int CadeiaId { get; set; }
    }
}
