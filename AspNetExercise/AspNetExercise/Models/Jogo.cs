using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetExercise.Models
{
    public class Jogo
    {
        [Key]
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public DateTime DataLancamento { get; set; }

        public Plataforma Plataforma { get; set; }
        
        public bool Disponivel { get; set; }
    }
}