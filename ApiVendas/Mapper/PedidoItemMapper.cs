using ApiVendas.Models;
using ApiVendas.Requests;
using ApiVendas.Responses;

namespace ApiVendas.Mapper
{
    public class PedidoItemMapper
    {
        public static PedidoItem Mapper(PedidoItemRequest PedidoItemRequest)
        {
            return new PedidoItem()
            {
                id = PedidoItemRequest.id,
                quantidade = PedidoItemRequest.quantidade,
                valorUnitario = PedidoItemRequest.valorUnitario,
                Produto = PedidoItemRequest.Produto
            };
        }

        public static PedidoItemResponse Mapper(PedidoItem PedidoItem)
        {
            return new PedidoItemResponse()
            {
                id = PedidoItem.id.ToString(),
                quantidade = PedidoItem.quantidade.ToString(),
                valorUnitario = PedidoItem.valorUnitario.ToString(),
                Produto = PedidoItem.Produto
            };
        }
    }
}
