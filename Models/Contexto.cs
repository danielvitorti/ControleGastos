using Microsoft.EntityFrameworkCore;

namespace ControleGastos.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Conta>().HasKey(m => m.Id);
            builder.Entity<FormaPagamento>().HasKey(m => m.Id);
            builder.Entity<Lancamento>().HasKey(m => m.Id);
            builder.Entity<TipoLancamento>().HasKey(m => m.Id);
            builder.Entity<Competencia>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
        public DbSet<Competencia> Competencia { get; set; }
        public DbSet<TipoLancamento> TipoLancamento { get; set; }
    }
}
