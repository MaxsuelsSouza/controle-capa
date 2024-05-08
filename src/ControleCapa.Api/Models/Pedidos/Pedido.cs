using ControleCapa.Api.Models.Fornecedores;
using ControleCapa.Api.Models.Pessoas;

namespace ControleCapa.Api.Models.Pedidos
{
    public class Pedido
    {
        public Guid PedidoId { get; set; }
        public Guid FornecedorId { get; set; }
        public Guid GestorId { get; set; }
        public ModelosCapas ModelosCapas { get; set; }
        public Fornecedor? Fornecedor { get; set; }
        public Gestor? Gestor { get; set; }
    }
}