using APIPontoColaborador.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPontoColaborador.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {}

        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Equipes> Equipes { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Liderancas> Lidencas { get; set; }
        public DbSet<Ponto> Pontos { get; set; }
    }
}
