using ApiVendas.Models;

namespace ApiVendas.Repositories
{
    public class ClienteRepository
    {
        public static void Gravar(Cliente Cliente)
        {
            BaseRepository.Command(Cliente);
        }

        public static void Atualizar(Cliente Cliente)
        {
            BaseRepository.Command(Cliente, true);
        }

        public static List<Cliente> Buscar(int id = 0, string descicao = "")
        {
            string sql = "select * from Cliente";

            if (id > 0)
            {
                sql += " where id = @idCliente";
            }

            if (!string.IsNullOrEmpty(descicao))
            {
                if (sql.Contains("where"))
                {
                    sql += " and descricao like @descricaoCliente";
                }
                else
                {
                    sql += " where descricao like @descricaoCliente";
                }
            }

            var retorno = BaseRepository.QuerySql<Cliente>(sql, new { idCliente = id, descricaoCliente = "%" + descicao + "%" });
            return retorno;
        }
    }
}
