using ApiVendas.Models;
using ApiVendas.Requests;
using ApiVendas.Responses;

namespace ApiVendas.Mapper
{
    public static class ClienteMapper
    {
        //A classe mapper serve para pegar as informações guardadas da pasta request e exibir com maior facilidade na classe do controller
        public static Cliente Mapper(ClienteRequest clienteRequest)
        {
            return new Cliente()
            {
                id = clienteRequest.id,
                nome = clienteRequest.nome,
                email = clienteRequest.email,
                dataNascimento = clienteRequest.dataNascimento
            };
        }

        public static ClienteResponse Mapper(Cliente cliente)
        {
            return new ClienteResponse()
            {
                id = cliente.id.ToString(),
                nome = cliente.nome,
                email = cliente.email,
                dataNascimento = cliente.dataNascimento.ToString()
            };
        }
    }
}
