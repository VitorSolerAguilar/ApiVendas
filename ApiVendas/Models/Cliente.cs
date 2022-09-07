namespace ApiVendas.Models
{
    public class Cliente
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }
        
        public DateTime dataNascimento { get; set; }
    }
}
