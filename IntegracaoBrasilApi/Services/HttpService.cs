using IntegracaoBrasilApi.DTOs;
using System.Dynamic;
using System.Text.Json;

namespace IntegracaoBrasilApi.Services
{
    public class HttpService
    {
        private readonly HttpClient _http;

        public HttpService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ResponseGenerico<T>> HttpGet<T>(string url) where T : class
        {
            var response = new ResponseGenerico<T>();

            var resp = await _http.GetAsync(url);
            var content = await resp.Content.ReadAsStringAsync();

            response.CodigoHttp = resp.StatusCode;

            if (resp.IsSuccessStatusCode)
            {
                response.Dados = JsonSerializer.Deserialize<T>(content);
            }
            else
            {
                response.Erro = JsonSerializer.Deserialize<ExpandoObject>(content);
            }

            return response;
        }
    }
}
