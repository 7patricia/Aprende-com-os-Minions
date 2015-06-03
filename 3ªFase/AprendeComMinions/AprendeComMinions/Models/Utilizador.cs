using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;

namespace AprendeComMinions.Models
{
    public class Utilizador
    {
        public int UtilizadorID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public int NrRespostasCertas { get; set; }
        public int NrRespostasErradas { get; set; }
        public int NrTestesRealizados { get; set; }
        public int NrSessoesEstudo { get; set; }
        public int GrauDif { get; set; }
        public List<String> TemasPreferidos { get; set; }


        public int getLoggedID(int id) {
            return Convert.ToInt32(Membership.GetUser().ProviderUserKey.ToString());
        }

    }

    public class LoginModel {
        [Required]
        [Display(Name = "Nome do Utilizador")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Manter sessão ligada")]
        public bool RememberMe { get; set; }
    }

    public class RegistarModel { 
        [Required]
        [Display(Name= "Nome do Utilizador")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar password")]
        [Compare("Password", ErrorMessage = "As password inseridas não são iguais")]
        public string ConfirmarPassword { get; set; }

    }

    public class CreateModel
    {
        [Required]
        [Display(Name = "Nome do Utilizador")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar password")]
        [Compare("Password", ErrorMessage = "As password inseridas não são iguais")]
        public string ConfirmarPassword { get; set; }

    }

    public class EditModel
    {
        [Required]
        [Display(Name = "UserID")]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Nome de Utilizador")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar password")]
        [Compare("Password", ErrorMessage = "As password inseridas não são iguais")]
        public string ConfirmarPassword { get; set; }

    }



}