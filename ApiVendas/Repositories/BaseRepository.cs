using ApiVendas.Models;
using Dapper;
using Dapper.Contrib.Extensions;
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

        public static void Delete<T>(int id) where T : BaseModel
        {
            using (var connection = new SqlConnection("Server=.\\sqlexpress;Database=vendas;Trusted_Connection=True;"))
            {
                string query = $"select * from {typeof(T).Name} where id = @id";
                var objeto = connection.Query<T>(query, new {id});
                connection.Delete(objeto);
            }
        }

        public static void Command<T>(T objeto, bool editar = false, object parameter = null) where T : BaseModel
        {
            using (var connection = new SqlConnection("Server=.\\sqlexpress;Database=vendas;Trusted_Connection=True;"))
            {
                if (editar)
                {
                    connection.Update(objeto);
                }
                else
                {
                    connection.Insert(objeto);
                }
            }
        }
    }
}
