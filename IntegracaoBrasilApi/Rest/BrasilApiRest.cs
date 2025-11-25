using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using IntegracaoBrasilApi.Models;
using System.Dynamic;
using System.Text.Json;

namespace IntegracaoBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");

            var response = new ResponseGenerico<List<BancoModel>>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.Dados = objResponse;
                }
                else
                {
                    response.Erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");

            var response = new ResponseGenerico<BancoModel>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<BancoModel>(contentResp);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.Dados = objResponse;
                }
                else
                {
                    response.Erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGenerico<List<MoedaModel>>> BuscarMoedas()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cambio/v1/moedas");

            var response = new ResponseGenerico<List<MoedaModel>>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<MoedaModel>>(contentResp);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.Dados = objResponse;
                }
                else
                {
                    response.Erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGenerico<CambioModel>> BuscarCambio(string moeda, string data)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cambio/v1/cotacao/{moeda}/{data}");

            var response = new ResponseGenerico<CambioModel>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<CambioModel>(contentResp);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.Dados = objResponse;
                }
                else
                {
                    response.Erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGenerico<CepModel>> BuscarCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGenerico<CepModel>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<CepModel>(contentResp);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.Dados = objResponse;
                }
                else
                {
                    response.Erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGenerico<CepModel>> BuscarCepV2(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v2/{cep}");

            var response = new ResponseGenerico<CepModel>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<CepModel>(contentResp);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.Dados = objResponse;
                }
                else
                {
                    response.Erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGenerico<CnpjModel>> BuscarCnpj(string cnpj)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cnpj/v1/{cnpj}");

            var response = new ResponseGenerico<CnpjModel>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<CnpjModel>(contentResp);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.Dados = objResponse;
                }
                else
                {
                    response.Erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }
    }
}
