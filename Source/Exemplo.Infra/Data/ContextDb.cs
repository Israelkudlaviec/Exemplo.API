using Exemplo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exemplo.Infra.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            #region -- Configurações de Cliente --
            modelBuilder.Entity<Cliente>().Property(e => e.Cpf)
                   .HasColumnType("varchar(11)")
                   .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
            #endregion

            #region -- Configurações de Contato --
            modelBuilder.Entity<Contato>().Property(e => e.NomeContato)
              .HasColumnType("varchar(200)")
              .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
              .HasColumnType("varchar(100)")
              .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
              .HasColumnType("varchar(15)");
            #endregion
        }
    }
}
