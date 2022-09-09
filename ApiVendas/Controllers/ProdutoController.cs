using ApiVendas.Models;
using ApiVendas.Repositories;
using ApiVendas.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        //Esse metodo retorna uma lista de Produtos 
        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            return ProdutoRepository.Buscar(0, "fe");
        }

        //Busca um unico Produto pelo seu id
        [HttpGet("{id}")]
        public ActionResult<Produto> Get(string id)
        {
            var produto = new Produto()
            {
                id = 3,
                descricao = "Mouse",
                estoque = 14,
                valor = 50
            };

            return produto;
        }

        //Retorna uma menssagem de que os dados foram salvos

        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] Produto request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro cadastrado com suesso!"
            };

            return retorno;
        }

        //Deleta um Produto 
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] Produto request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com suesso!"
            };

            return retorno;
        }

        //Deleta um Produto pelo id
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
