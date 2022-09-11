using Dapper.Contrib.Extensions;

namespace ApiVendas.Models
{
    [Table("PedidoItens")]
    public class PedidoItem : BaseModel
    {
        [ExplicitKey]
        public int id { get; set; }

        public int quantidade { get; set; }

        public decimal valorUnitario { get; set; }

        public Produto Produto { get; set; }
    }
}
