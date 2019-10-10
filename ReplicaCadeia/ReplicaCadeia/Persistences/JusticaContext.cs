using _07_Fiap_Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace _07_Fiap_Web.AspNet.Persistences
{
    public class JusticaContext : DbContext
    {
        public DbSet<Bandido> Bandidos { get; set; }
        public DbSet<Cadeia> Cadeias { get; set; }

        public JusticaContext(DbContextOptions o) : base(o)
        {

        }
    }
}
