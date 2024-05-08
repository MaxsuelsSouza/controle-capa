namespace ControleCapa.Api.Models.Pessoas
{
    public class Gestor
    {
        public Guid GestorId { get; set; }
        public Guid PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
    }
}