using Dapper;
using System.Data.SqlClient;

namespace ApiVendas.Repositories
{
    public static class BaseRepository
    {
        public static List<T> QuerySql<T>(string sql, object parameter = null)
        {
            List<T> orderDetail;

            using (var connection = new SqlConnection("Server=.\\sqlexpress;Database=vendas;Trusted_Connection=True;"))
            {
                orderDetail = connection.Query<T>(sql, parameter).ToList();
            }

            return orderDetail;
        }
    }
}
