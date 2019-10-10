using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExercise.Models
{
    public class Jogo
    {
        [Key]
        [HiddenInput]
        public int Codigo { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        public Plataforma Plataforma { get; set; }
        
        [DefaultValue(false)]
        public bool Disponivel { get; set; }
    }
}