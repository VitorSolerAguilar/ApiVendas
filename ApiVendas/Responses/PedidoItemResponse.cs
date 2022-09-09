using ApiVendas.Models;

namespace ApiVendas.Responses
{
    public class PedidoItemResponse
    {
        public string id { get; set; }
        public string quantidade { get; set; }
        public string valorUnitario { get; set; }
        public Produto Produto { get; set; }
    }
}
