using ApiVendas.Models;
using ApiVendas.Requests;
using ApiVendas.Responses;

namespace ApiVendas.Mapper
{
    public class ProdutoMapper
    {
        public static Produto Mapper(ProdutoRequest ProdutoRequest)
        {
            return new Produto()
            {
                id = ProdutoRequest.id,
                descricao = ProdutoRequest.descricao,
                estoque = ProdutoRequest.estoque,
                valor = ProdutoRequest.valor
            };
        }

        public static ProdutoResponse Mapper(Produto Produto)
        {
            return new ProdutoResponse()
            {
                id = Produto.id.ToString(),
                descricao = Produto.descricao,
                estoque = Produto.estoque.ToString(),
                valor = Produto.valor.ToString()
            };
        }
    }
}
