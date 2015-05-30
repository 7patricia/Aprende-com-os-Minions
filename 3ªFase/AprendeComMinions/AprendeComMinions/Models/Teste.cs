using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AprendeComMinions.Models
{
    public class Teste
    {
        public int TesteID { get; set; }
        public DateTime DataRealizacao { get; set; }
        public float Classificacao { get; set; }
        public string Tema { get; set; }

        public virtual ICollection<SessaoEstudo> SessaoEstudos { get; set; }

        public virtual ICollection<Pergunta> Perguntas { get; set; } 

    }
}