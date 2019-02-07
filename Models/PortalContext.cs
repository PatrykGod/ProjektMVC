using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NowaBiblioteka.Models;

namespace Biblioteka.Models
{
    // Możesz dodać dane profilu dla użytkownika, dodając więcej właściwości do klasy Uzytkownik. Odwiedź stronę https://go.microsoft.com/fwlink/?LinkID=317594, aby dowiedzieć się więcej.


    public class PortalContext : IdentityDbContext
    {
        public PortalContext()
            : base("PortalConnection")
        {
        }

        public static PortalContext Create()
        {
            return new PortalContext();
        }

        
        public DbSet<Egzemplarz> Egzemplarz { get; set; }
        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<Tworca> Twórcy { get; set; }
        public DbSet<Wydanie> Wydanie { get; set; }
        public DbSet<Wydawnictwo> Wydawnictwo { get; set; }
        public DbSet<Wypozyczenie> Wypozyczenie { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }

}