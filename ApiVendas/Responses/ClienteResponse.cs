namespace ApiVendas.Responses
{
    public class ClienteResponse
    {
        //Nesta classe seria para a segurança de uma aplicação, serve para colocar os campo que o usuario tera acesso
        //Se na aplicação tivesse um campo senha, não poderia ser inserido nesa classe por segurança dos dados
        public string id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string dataNascimento { get; set; }
    }
}
