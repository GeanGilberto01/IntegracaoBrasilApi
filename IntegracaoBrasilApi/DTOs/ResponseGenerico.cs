using System.Dynamic;
using System.Net;

namespace IntegracaoBrasilApi.DTOs
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }

        public T? Dados { get; set; }

        public ExpandoObject? Erro { get; set; }
    }
}
