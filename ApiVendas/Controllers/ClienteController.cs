using ApiVendas.Models;
using ApiVendas.Response;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        //Esse metodo retorna uma lista de clientes 
        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            var cliente = new Cliente()
            {
                id = 1,
                nome = "Diego",
                email = "diego@gmail.com",
                dataNascimento = DateTime.Now.AddYears(-20)
            };


            var cliente2 = new Cliente()
            {
                id = 2,
                nome = "Junior",
                email = "junior@gmail.com",
                dataNascimento = DateTime.Now.AddYears(-30)
            };

            var clientes = new List<Cliente>();
            clientes.Add(cliente);
            clientes.Add(cliente2);

            return clientes;

        }

        //Busca um unico cliente pelo seu id
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(string id)
        {
            var cliente = new Cliente()
            {
                id = 1,
                nome = "Matheus",
                email = "matheus@gmail.com",
                dataNascimento = DateTime.Now.AddYears(-25)
            };

            return cliente;
        }

        //Retorna uma menssagem de que os dados foram salvos

        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] Cliente request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro cadastrado com suesso!"
            };

            return retorno;
        }

        //Deleta um cliente 
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] Cliente request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com suesso!"
            };

            return retorno;
        }

        //Deleta um cliente pelo id
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
