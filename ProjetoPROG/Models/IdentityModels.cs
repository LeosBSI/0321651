using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ProjetoPROG.Models
{
    
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Cadastro> Cadastros { get; set; }

        public DbSet<Cadastro> ID { get; set; }

        public DbSet<Cadastro> Nome { get; set; }

        public DbSet<Cadastro> descricao { get; set; }

        public DbSet<Cadastro> preco { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection"){

        }
        
            public static ApplicationDbContext Create(){
                return new ApplicationDbContext();
            }
        }
    }
