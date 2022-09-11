using Dapper.Contrib.Extensions;

namespace ApiVendas.Models
{
    [Table("Cliente")]
    public class Cliente : BaseModel
    {
        [ExplicitKey]
        public int id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }
        
        public DateTime dataNascimento { get; set; }
    }
}
