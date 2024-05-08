namespace ControleCapa.Api.Models.Fornecedores
{
    public class Fornecedor
    {
        public Guid FornecedorId { get; set; }
        public string? NomeFantasia { get; set; }
        public string? RazaoSocial { get; set; }
        public string? CpfCnpj { get; set; }
        public string? Email { get; set; }
    }
}