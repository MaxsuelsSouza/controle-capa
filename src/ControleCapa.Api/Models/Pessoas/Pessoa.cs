namespace ControleCapa.Api.Models.Pessoas
{
    public class Pessoa
    {
        public Guid PessoaId { get; set; }
        public string? Nome { get; set; }
        public string? Idade { get; set; }
        public string? CpfCnpj { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
}