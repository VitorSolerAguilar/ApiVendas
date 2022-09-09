using ApiVendas.Models;

namespace ApiVendas.Requests
{
    public class PedidoItemRequest
    {
        public string id { get; set; }
        public string quantidade { get; set; }
        public string valorUnitario { get; set; }
        public Produto Produto { get; set; }
    }
}
