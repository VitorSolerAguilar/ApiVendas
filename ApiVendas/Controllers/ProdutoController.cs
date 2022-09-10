using ApiVendas.Mapper;
using ApiVendas.Models;
using ApiVendas.Repositories;
using ApiVendas.Requests;
using ApiVendas.Response;
using ApiVendas.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        //Esse metodo retorna uma lista de Produtos 
        [HttpGet]
        public ActionResult<List<ProdutoResponse>> Get()
        {
            var produtos = ProdutoRepository.Buscar().Select(p=> ProdutoMapper.Mapper(p));

            return produtos.ToList();
        }

        //Busca um unico Produto pelo seu id
        [HttpGet("{id}")]
        public ActionResult<ProdutoResponse> Get(int id)
        {
            var produto = ProdutoMapper.Mapper(ProdutoRepository.Buscar(id).FirstOrDefault());

            return produto;
        }

        //Retorna uma menssagem de que os dados foram salvos

        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ProdutoRequest request)
        {
            var produto = ProdutoMapper.Mapper(request);

            ProdutoRepository.Gravar(produto);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro cadastrado com suesso!"
            };

            return retorno;
        }

        //Deleta um Produto 
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] ProdutoRequest request)
        {
            var produto = ProdutoMapper.Mapper(request);

            ProdutoRepository.Atualizar(produto);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com suesso!"
            };

            return retorno;
        }

        //Deleta um Produto pelo id
        [HttpDelete("{id}")]
        public ActionResult<ReturnResponse> Delete(int id)
        {
            ProdutoRepository.Delete(id);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com sucesso!"
            };
            return retorno;
        }
    }
}
