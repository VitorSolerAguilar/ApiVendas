using ApiVendas.Models;

namespace ApiVendas.Repositories
{
    public class PedidoRepository
    {
        public static void Gravar(Pedido Pedido)
        {
            BaseRepository.Command(Pedido);
        }

        public static void Atualizar(Pedido Pedido)
        {
            BaseRepository.Command(Pedido, true);
        }

        public static List<Pedido> Buscar(int id = 0, string descicao = "")
        {
            string sql = "select * from Pedido";

            if (id > 0)
            {
                sql += " where id = @idPedido";
            }

            if (!string.IsNullOrEmpty(descicao))
            {
                if (sql.Contains("where"))
                {
                    sql += " and descricao like @descricaoPedido";
                }
                else
                {
                    sql += " where descricao like @descricaoPedido";
                }
            }

            var retorno = BaseRepository.QuerySql<Pedido>(sql, new { idPedido = id, descricaoPedido = "%" + descicao + "%" });
            return retorno;
        }
    }
}
