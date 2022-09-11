using Dapper.Contrib.Extensions;

namespace ApiVendas.Models
{
    [Table("Pedido")]
    public class Pedido : BaseModel
    {
        [ExplicitKey]
        public int numeroPedido { get; set; }

        public DateTime data { get; set; }

        public string tipo { get; set; }

        public Cliente Cliente { get; set; }
        public List<PedidoItem> Itens { get; set; }
    }
}
