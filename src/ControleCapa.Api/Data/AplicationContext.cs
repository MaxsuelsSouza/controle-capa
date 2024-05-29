using ControleCapa.Api.Data.Contexto;
using ControleCapa.Api.Models.Fornecedores;
using ControleCapa.Api.Models.Pedidos;
using ControleCapa.Api.Models.Pessoas;
using Microsoft.EntityFrameworkCore;

namespace ControleCapa.Api.Data
{
    public class AplicationContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Gestor> Gestores { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfiguracaoContextoCliente());
            modelBuilder.ApplyConfiguration(new ConfiguracaoContextoFornecedor());
            modelBuilder.ApplyConfiguration(new ConfiguracaoContextoGestor());
            modelBuilder.ApplyConfiguration(new ConfiguracaoContextoPedido());
            modelBuilder.ApplyConfiguration(new ConfiguracaoContextoPessoa());
        }
    }
}