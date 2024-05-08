namespace ControleCapa.Api.Models.Pessoas
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public Guid PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
    }
}