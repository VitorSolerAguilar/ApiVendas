using ApiVendas.Mapper;
using ApiVendas.Models;
using ApiVendas.Repositories;
using ApiVendas.Requests;
using ApiVendas.Response;
using ApiVendas.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        //Esse metodo retorna uma lista de pedidos 
        [HttpGet]
        public ActionResult<List<PedidoResponse>> Get()
        {
            var PedidoGet = PedidoRepository.Buscar().Select(p => PedidoMapper.Mapper(p));

            return PedidoGet.ToList();
        }


        //Busca um unico Pedido pelo seu id
        [HttpGet("{numeroPedido}")]
        public ActionResult<PedidoResponse> Get(int numeroPedido)
        {
            var PedidoId = PedidoMapper.Mapper(PedidoRepository.Buscar(numeroPedido).FirstOrDefault());

            return PedidoId;
        }

        //Retorna uma menssagem de que os dados foram salvos
        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] PedidoRequest request)
        {
            var NovoPedido = PedidoMapper.Mapper(request);

            PedidoRepository.Gravar(NovoPedido);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro cadastrado com suesso!"
            };

            return retorno;
        }

        //Deleta um Pedido 
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] PedidoRequest request)
        {
            var AtualizarPedido = PedidoMapper.Mapper(request);

            PedidoRepository.Atualizar(AtualizarPedido);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com suesso!"
            };

            return retorno;
        }

        //Deleta um Pedido pelo id
        [HttpDelete("{id}")]
        public ActionResult<ReturnResponse> Delete(int id)
        {
            PedidoRepository.Delete(id);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com sucesso!"
            };
            return retorno;
        }
    }
}
