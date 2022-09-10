namespace ApiVendas.Models
{
    public class Pedido : BaseModel
    {
        public int numeroPedido { get; set; }

        public DateTime data { get; set; }

        public string tipo { get; set; }

        public Cliente Cliente { get; set; }
        public List<PedidoItem> Itens { get; set; }
    }
}
