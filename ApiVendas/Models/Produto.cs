
using Dapper.Contrib.Extensions;

namespace ApiVendas.Models
{
    [Table("produto")]
    public class Produto : BaseModel
    {
        [ExplicitKey]
        public int id { get; set; }

        public string descricao { get; set; }

        public int estoque { get; set; }

        public decimal valor { get; set; }
    }
}
