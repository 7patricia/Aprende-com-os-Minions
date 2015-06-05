using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AprendeComMinions.Models
{
    public class SessaoEstudo
    {
        public int SessaoEstudoID {get; set;}
        public DateTime Data { get; set; }
        public string Tema { get; set; }
        public virtual ICollection<Aula> Aulas { get; set; }
        public virtual ICollection<Teste> Testes { get; set; }
        public virtual ICollection<Exercicio> Exercicios { get; set; }
        public virtual Utilizador Utilizador { get; set; }

    }


}