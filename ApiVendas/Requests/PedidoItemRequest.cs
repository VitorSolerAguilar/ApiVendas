using ApiVendas.Models;

namespace ApiVendas.Requests
{
    public class PedidoItemRequest
    {
        public int id { get; set; }
        public int quantidade { get; set; }
        public decimal valorUnitario { get; set; }
        public Produto Produto { get; set; }
    }
}
