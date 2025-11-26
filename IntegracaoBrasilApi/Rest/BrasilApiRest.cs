using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using IntegracaoBrasilApi.Models;
using IntegracaoBrasilApi.Services;
using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IntegracaoBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        private readonly HttpService _http;

        public BrasilApiRest(HttpService http)
        {
            _http = http;
        }

        public async Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            return await _http.HttpGet<List<BancoModel>>($"https://brasilapi.com.br/api/banks/v1");
        }

        public async Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            return await _http.HttpGet<BancoModel>($"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");
        }

        public async Task<ResponseGenerico<List<MoedaModel>>> BuscarMoedas()
        {
            return await _http.HttpGet<List<MoedaModel>>($"https://brasilapi.com.br/api/cambio/v1/moedas");
        }

        public async Task<ResponseGenerico<CambioModel>> BuscarCambio(string moeda, string data)
        {
            return await _http.HttpGet<CambioModel>($"https://brasilapi.com.br/api/cambio/v1/cotacao/{moeda}/{data}");
        }

        public async Task<ResponseGenerico<CepModel>> BuscarCep(string cep)
        {
            return await _http.HttpGet<CepModel>($"https://brasilapi.com.br/api/cep/v1/{cep}");
        }

        public async Task<ResponseGenerico<CepModel>> BuscarCepV2(string cep)
        {
            return await _http.HttpGet<CepModel>($"https://brasilapi.com.br/api/cep/v2/{cep}");
        }

        public async Task<ResponseGenerico<CnpjModel>> BuscarCnpj(string cnpj)
        {
            return await _http.HttpGet<CnpjModel>($"https://brasilapi.com.br/api/cnpj/v1/{cnpj}");
        }
    }
}
