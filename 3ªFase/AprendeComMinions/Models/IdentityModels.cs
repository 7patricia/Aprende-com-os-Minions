using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AprendeComMinions.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("MinionsContext", throwIfV1Schema: false)
        {
        }

        public DbSet<Aula> Aulas { get; set; }
        public DbSet<SessaoEstudo> SessoesEstudo { get; set; }
        public DbSet<Teste> Testes { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}