using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AprendeComMinions.Models
{
    public class Aula
    {

        public int AulaID { get; set; }
        public string Tema { get; set; }
        public int GrauDif { get; set; }
        public string Titulo { get; set; }
        public string URLImagem { get; set; }
        public string URLVideo { get; set; }
        public virtual ICollection<SessaoEstudo> SessaoEstudos { get; set; }
        public virtual ICollection<Utilizador> Uttilizadores { get; set; }
        
    }
}