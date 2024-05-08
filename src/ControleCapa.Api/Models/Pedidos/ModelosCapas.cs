using System.ComponentModel;

namespace ControleCapa.Api.Models.Pedidos
{
    public enum ModelosCapas
    {
        [Description("SMART")]
        Smart = 0,
        [Description("STRONG")]
        Strong = 1,
        [Description("FULL")]
        Full = 2,
    }
}