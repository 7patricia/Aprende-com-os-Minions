using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AprendeComMinions.Models
{
    public class Duvida
    {
        public int DuvidaID { get; set; }
        public string Descricao { get; set; }
        public string URLVideo { get; set; }
        public virtual Exercicio Exercicio { get; set; }
    }
}