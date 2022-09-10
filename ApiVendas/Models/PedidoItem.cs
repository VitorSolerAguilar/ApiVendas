namespace ApiVendas.Models
{
    public class PedidoItem : BaseModel
    {
        public int id { get; set; }

        public int quantidade { get; set; }

        public decimal valorUnitario { get; set; }

        public Produto Produto { get; set; }
    }
}
