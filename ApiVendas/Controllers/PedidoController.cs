using ApiVendas.Models;
using ApiVendas.Response;
using Microsoft.AspNetCore.Mvc;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        //Esse metodo retorna uma lista de pedidos 
        [HttpGet]
        public ActionResult<List<Pedido>> Get()
        {
            var Pedido = new Pedido()
            {
                numeroPedido = 1,
                Cliente = new Cliente(),
                data = DateTime.Now,
                tipo = "V",
                Itens = new List<PedidoItem>()
            };


            var Pedido2 = new Pedido()
            {
                numeroPedido = 2,
                Cliente = new Cliente(),
                data = DateTime.Now,
                tipo = "V",
                Itens = new List<PedidoItem>()
            };

            var pedidos = new List<Pedido>();
            pedidos.Add(Pedido);
            pedidos.Add(Pedido2);

            return pedidos;

        }

        //Busca um unico Pedido pelo seu id
        [HttpGet("{numeroPedido}")]
        public ActionResult<Pedido> Get(string numeroPedidoid)
        {
            var Pedido = new Pedido()
            {
                numeroPedido = 3,
                Cliente = new Cliente(),
                data = DateTime.Now,
                tipo = "V",
                Itens = new List<PedidoItem>()
            };

            return Pedido;
        }

        //Retorna uma menssagem de que os dados foram salvos

        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] Pedido request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro cadastrado com suesso!"
            };

            return retorno;
        }

        //Deleta um Pedido 
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] Pedido request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com suesso!"
            };

            return retorno;
        }

        //Deleta um Pedido pelo id
        [HttpDelete("{id}")]
        public ActionResult<ReturnResponse> Delete(string id)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com sucesso!"
            };
            return retorno;
        }
    }
}
