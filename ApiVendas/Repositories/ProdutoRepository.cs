using ApiVendas.Models;

namespace ApiVendas.Repositories
{
    public static class ProdutoRepository
    {
        //Essa classe serve para conexão com o banco de dados, onde ficaram as consultas do sql para retonar para a aplicação
        public static void Gravar(Produto produto)
        {
            BaseRepository.Command(produto);
        }

        public static void Delete(int id)
        {
            BaseRepository.Delete<Produto>(id);
        }

        public static void Atualizar(Produto produto)
        {
            BaseRepository.Command(produto, true);
        }

        //Esse metodo serve para retornar uma lista de produtos ou seja, varios itens.
        public static List<Produto> Buscar(int id = 0, string descicao = "")
        {
            string sql = "select * from produto";

            if (id > 0)
            {
                sql += " where id = @idProduto";
            }

            if (!string.IsNullOrEmpty(descicao))
            {
                if (sql.Contains("where"))
                {
                    sql += " and descricao like @descricaoProduto";
                }
                else
                {
                    sql += " where descricao like @descricaoProduto";
                }
            }

            var retorno = BaseRepository.QuerySql<Produto>(sql, new { idProduto = id, descricaoProduto = "%" + descicao + "%" });
            return retorno;
        }
    }
}
