using ApiVendas.Models;
using ApiVendas.Requests;
using ApiVendas.Responses;

namespace ApiVendas.Mapper
{
    public class PedidoMapper
    {
        public static Pedido Mapper(PedidoRequest PedidoRequest)
        {
            return new Pedido()
            {
                numeroPedido = PedidoRequest.numeroPedido,
                data = PedidoRequest.data,
                tipo = PedidoRequest.tipo,
                Cliente = PedidoRequest.Cliente
            };
        }

        public static PedidoResponse Mapper(Pedido Pedido)
        {
            return new PedidoResponse()
            {
                numeroPedido = Pedido.numeroPedido,
                data = Pedido.data.ToString(),
                tipo = Pedido.tipo.ToString(),
                Cliente = Pedido.Cliente
            };
        }
    }
}
