namespace ApiVendas.Requests
{
    public class ClienteRequest
    {
        //Esta classe tem como função obter os dados de entrada do usuario
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
    }
}
