using ControleCapa.Api.Models.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleCapa.Api.Data.Contexto
{
    public class ConfiguracaoContextoPessoa : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("siscap", "pessoas");

            builder.HasKey(p => p.PessoaId);
        }
    }
}