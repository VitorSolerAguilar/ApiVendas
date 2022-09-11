using ApiVendas.Mapper;
using ApiVendas.Models;
using ApiVendas.Repositories;
using ApiVendas.Requests;
using ApiVendas.Response;
using ApiVendas.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        //Esse metodo retorna uma lista de ClienteRequests 
        [HttpGet]
        public ActionResult<List<ClienteResponse>> Get()
        {
            var cliente = ClienteRepository.Buscar().Select(c => ClienteMapper.Mapper(c));

            return cliente.ToList();
        }

        //Busca um unico ClienteResponse pelo seu id
        [HttpGet("{id}")]
        public ActionResult<ClienteResponse> Get(int id)
        {
            var cliente = ClienteMapper.Mapper(ClienteRepository.Buscar(id).FirstOrDefault());

            return cliente;
        }

        //Retorna uma menssagem de que os dados foram salvos
        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ClienteRequest request)
        {
            var NovoCliente = ClienteMapper.Mapper(request);

            ClienteRepository.Gravar(NovoCliente);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro cadastrado com suesso!"
            };

            return retorno;
        }

        //Deleta um ClienteRequest 
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] ClienteRequest request)
        {
            var AtualizarCliente = ClienteMapper.Mapper(request);

            ClienteRepository.Atualizar(AtualizarCliente);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com suesso!"
            };

            return retorno;
        }

        //Deleta um ClienteRequest pelo id
        [HttpDelete("{id}")]
        public ActionResult<ReturnResponse> Delete(int id)
        {
            ClienteRepository.Delete(id);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com sucesso!"
            };
            return retorno;
        }
    }
}
