using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AprendeComMinions.Models
{
    public class Resposta
    {
        public int RespostaID { get; set; }
        public string Descricao { get; set; }
        public virtual Pergunta Pergunta { get; set; }
        public virtual Resposta RespostaCerta { get; set; }
    }
}