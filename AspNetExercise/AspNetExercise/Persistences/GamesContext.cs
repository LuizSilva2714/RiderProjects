using AspNetExercise.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetExercise.Persistences
{
    public class GamesContext : DbContext
    {
        public DbSet<Jogo> Jogos { get; set; }

        public GamesContext(DbContextOptions options): base((options)) { }
    }
}