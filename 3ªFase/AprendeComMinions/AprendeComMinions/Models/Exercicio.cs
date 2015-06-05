using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AprendeComMinions.Models
{
    public class Exercicio
    {
        [Key, ForeignKey("Duvida")]
        public int ExercicioID { get; set; }
        public int GrauDif { get; set; }
        public string Tema { get; set; }
        public string URLImagem { get; set; }
        public virtual Duvida Duvida { get; set; }
        public virtual ICollection<SessaoEstudo> SessaoEstudos { get; set; }
        public virtual ICollection<Pergunta> Perguntas { get; set; }
        public virtual ICollection<Utilizador> Utilizadores { get; set; }
    }
}