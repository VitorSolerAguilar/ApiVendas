using ApiVendas.Models;

namespace ApiVendas.Requests
{
    public class PedidoRequest
    {
        public string numeroPedido { get; set; }
        public string data { get; set; }
        public string tipo { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Itens { get; set; }
    }
}
