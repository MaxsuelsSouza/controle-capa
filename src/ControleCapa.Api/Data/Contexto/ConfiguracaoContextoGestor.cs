using ControleCapa.Api.Models.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleCapa.Api.Data.Contexto
{
    public class ConfiguracaoContextoGestor : IEntityTypeConfiguration<Gestor>
    {
        public void Configure(EntityTypeBuilder<Gestor> builder)
        {
            builder.ToTable("siscap", "gestores");

            builder.HasKey(p => p.GestorId);

            builder.HasOne(p => p.Pessoa)
                .WithMany()
                .HasForeignKey(p => p.PessoaId);
        }
    }
}