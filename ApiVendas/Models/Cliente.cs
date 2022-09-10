namespace ApiVendas.Models
{
    public class Cliente : BaseModel
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }
        
        public DateTime dataNascimento { get; set; }
    }
}
