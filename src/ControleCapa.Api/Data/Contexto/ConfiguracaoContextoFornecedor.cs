using ControleCapa.Api.Models.Fornecedores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleCapa.Api.Data.Contexto
{
    public class ConfiguracaoContextoFornecedor : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("siscap","fornecedores");

            builder.HasKey(p => p.FornecedorId);
        }
    }
}