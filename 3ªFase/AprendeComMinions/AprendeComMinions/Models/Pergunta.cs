using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace AprendeComMinions.Models
{
    public class Pergunta
    {
        public int PerguntaID { get; set; }
        public string Descricao { get; set; }
        public string URLImagem { get; set; }
        public virtual Teste Teste { get; set; }
        public virtual Exercicio Exercicio { get; set; }
        public string RespCerta { get; set; }
        public virtual ICollection<Resposta> Respostas { get; set; }
        public virtual ICollection<Teste> Testes { get; set; }
    }
}