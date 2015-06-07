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
        public string RespA { get; set; }
        public string RespB { get; set; }
        public string RespC { get; set; }
        public string RespD { get; set; }
        public virtual Pergunta Pergunta { get; set; }
    }
}