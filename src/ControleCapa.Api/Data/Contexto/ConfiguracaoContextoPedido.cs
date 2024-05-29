using ControleCapa.Api.Models.Pedidos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleCapa.Api.Data.Contexto
{
    public class ConfiguracaoContextoPedido : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {

            builder.ToTable("siscap", "Pedidos");

            builder.HasKey(p => p.PedidoId);

            builder.HasOne(p => p.Gestor)
                .WithMany()
                .HasForeignKey(p => p.GestorId);

            builder.HasOne(p => p.Fornecedor)
                .WithMany()
                .HasForeignKey(p => p.FornecedorId);

        }
    }
}