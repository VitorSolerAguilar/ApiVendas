using ApiVendas.Mapper;
using ApiVendas.Models;
using ApiVendas.Requests;
using ApiVendas.Response;
using ApiVendas.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteRequestController : ControllerBase
    {

        //Esse metodo retorna uma lista de ClienteRequests 
        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            var Cliente = new Cliente()
            {
                id = 1,
                nome = "Diego",
                email = "diego@gmail.com",
                dataNascimento = DateTime.Now.AddYears(-20)
            };

            var Cliente2 = new Cliente()
            {
                id = 2,
                nome = "Junior",
                email = "junior@gmail.com",
                dataNascimento = DateTime.Now.AddYears(-30)
            };

            var ClienteResponses = new List<ClienteResponse>();
            ClienteResponses.Add(ClienteMapper.Mapper(Cliente));
            ClienteResponses.Add(ClienteMapper.Mapper(Cliente2));
            
            return Ok(ClienteResponses);
        }

        //Busca um unico ClienteResponse pelo seu id
        [HttpGet("{id}")]
        public ActionResult<ClienteResponse> Get(string id)
        {
            var ClienteResponse = new ClienteResponse()
            {
                id = "1",
                nome = "Matheus",
                email = "matheus@gmail.com",
                dataNascimento = DateTime.Now.AddYears(-25).ToString()
            };

            return ClienteResponse;
        }

        //Retorna uma menssagem de que os dados foram salvos

        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ClienteRequest request)
        {
            var NovoCliente = ClienteMapper.Mapper(request);

            var meuNovoCliente = ClienteMapper.Mapper(request);
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
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com suesso!"
            };

            return retorno;
        }

        //Deleta um ClienteRequest pelo id
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
