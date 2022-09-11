using ApiVendas.Models;
using ApiVendas.Response;
using Dapper;
using System.Data.SqlClient;

namespace ApiVendas.Repositories
{
    public class PedidoRepository
    {
        public static void Gravar(Pedido Pedido)
        {
            BaseRepository.Command(Pedido);
        }

        public static void Delete(int id)
        {
            BaseRepository.Delete<Pedido>(id);
        }

        public static void Atualizar(Pedido Pedido)
        {
            BaseRepository.Command(Pedido, true);
        }

        public static List<Pedido> Buscar(int numeroPedido = 0, int clienteId = 0)
        {
            string sql = @" select p.numeroPedido,
                                   p.data, 
                                   p.tipo,
                                   p.idClientes,
                                   c.id,
                                   c.nome,
                                   c.email,
                                   c.dataNascimento
                                   from Pedido p 
                                   join Cliente c on p.idClientes = c.id";

            if (numeroPedido > 0)
            {
                sql += " where numeroPedido = @numeroPedido";
            }

            if (clienteId > 0)
            {
                if (sql.Contains("where"))
                {
                    sql += " and idClientes = @idClientes";
                }
                else
                {
                    sql += " where idClientes = @idClientes";
                }
            }

            List<Pedido> orderDetail;

            using (var connection = new SqlConnection(BaseRepository.ConnectionString))
            {
                orderDetail = connection.Query<Pedido, Cliente, Pedido>(sql, map: mapPropriedades, splitOn: "id", param: new { numeroPedido = numeroPedido, idClientes = clienteId }).ToList();
            }

            return orderDetail;
        }

        private static Pedido mapPropriedades(Pedido pedido, Cliente cliente)
        {
            pedido.Cliente = cliente;

            return pedido;
        }
    }
}
