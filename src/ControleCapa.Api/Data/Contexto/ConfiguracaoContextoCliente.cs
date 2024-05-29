using ControleCapa.Api.Models.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleCapa.Api.Data.Contexto
{
    public class ConfiguracaoContextoCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("siscap", "clientes");

            builder.HasKey(p => p.ClienteId);

            builder.HasOne(p => p.Pessoa)
                .WithMany()
                .HasForeignKey(p => p.PessoaId);
        }
    }
}