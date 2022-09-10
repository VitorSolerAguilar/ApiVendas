namespace ApiVendas.Requests
{
    public class ProdutoRequest
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int estoque { get; set; }
        public decimal valor { get; set; }
    }
}
