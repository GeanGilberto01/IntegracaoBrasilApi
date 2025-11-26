using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using IntegracaoBrasilApi.Models;
using IntegracaoBrasilApi.Services;

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

        public async Task<ResponseGenerico<BancoModel>> BuscarBanco(int codigoBanco)
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

        public async Task<ResponseGenerico<CepModel>> BuscarCep(int cep)
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

        public async Task<ResponseGenerico<List<CorretoraModel>>> BuscarTodasCorretoras()
        {
            return await _http.HttpGet<List<CorretoraModel>>($"https://brasilapi.com.br/api/cvm/corretoras/v1");
        }

        public async Task<ResponseGenerico<CorretoraModel>> BuscarCorretora(string cnpj)
        {
            return await _http.HttpGet<CorretoraModel>($"https://brasilapi.com.br/api/cvm/corretoras/v1/{cnpj}");
        }

        public async Task<ResponseGenerico<List<CidadeModel>>> BuscarTodasCidades()
        {
            return await _http.HttpGet<List<CidadeModel>>($"https://brasilapi.com.br/api/cptec/v1/cidade");
        }

        public async Task<ResponseGenerico<CidadeModel>> BuscarCidade(string nomeCidade)
        {
            return await _http.HttpGet<CidadeModel>($"https://brasilapi.com.br/api/cvm/corretoras/v1/{nomeCidade}");
        }

        public async Task<ResponseGenerico<List<ClimaModel>>> BuscarCondicaoCapital()
        {
            return await _http.HttpGet<List<ClimaModel>>($"https://brasilapi.com.br/api/cptec/v1/clima/capital");
        }

        public async Task<ResponseGenerico<ClimaModel>> BuscarCondicaoAeroporto(string codicoIcao)
        {
            return await _http.HttpGet<ClimaModel>($"https://brasilapi.com.br/api/cptec/v1/clima/aeroporto/{codicoIcao}");
        }

        public async Task<ResponseGenerico<PrevisaoModel>> BuscarPrevisaoMeteorologicaCidade(int codigoCidade)
        {
            return await _http.HttpGet<PrevisaoModel>($"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{codigoCidade}");
        }

        public async Task<ResponseGenerico<PrevisaoModel>> BuscarPrevisaoMeteorologicaCidadeDias(int codigoCidade, int dias)
        {
            return await _http.HttpGet<PrevisaoModel>($"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{codigoCidade}/{dias}");
        }

        public async Task<ResponseGenerico<OndasModel>> BuscarPrevisaoOceanicaCidade(int codigoCidade)
        {
            return await _http.HttpGet<OndasModel>($"https://brasilapi.com.br/api/cptec/v1/ondas/{codigoCidade}");
        }

        public async Task<ResponseGenerico<OndasModel>> BuscarPrevisaoOceanicaCidadeDias(int codigoCidade, int dias)
        {
            return await _http.HttpGet<OndasModel>($"https://brasilapi.com.br/api/cptec/v1/ondas/{codigoCidade}/{dias}");
        }

        public async Task<ResponseGenerico<DddModel>> BuscarDdds(int ddd)
        {
            return await _http.HttpGet<DddModel>($"https://brasilapi.com.br/api/ddd/v1/{ddd}");
        }

        public async Task<ResponseGenerico<List<FeriadoModel>>> BuscarFeriados(int ano)
        {
            return await _http.HttpGet<List<FeriadoModel>>($"https://brasilapi.com.br/api/feriados/v1/{ano}");
        }

        public async Task<ResponseGenerico<List<MarcaModel>>> BuscarVeiculosMarcas(string tipoVeiculo)
        {
            return await _http.HttpGet<List<MarcaModel>>($"https://brasilapi.com.br/api/fipe/marcas/v1/{tipoVeiculo}");
        }

        public async Task<ResponseGenerico<List<PrecoModel>>> BuscarVeiculosPreco(string codigoFipe)
        {
            return await _http.HttpGet<List<PrecoModel>>($"https://brasilapi.com.br/api/fipe/preco/v1/{codigoFipe}");
        }

        public async Task<ResponseGenerico<List<TabelaModel>>> BuscarTabelasFipe()
        {
            return await _http.HttpGet<List<TabelaModel>>($"https://brasilapi.com.br/api/fipe/tabelas/v1");
        }

        public async Task<ResponseGenerico<List<ModeloModel>>> BuscarVeiculosModelos(string tipoVeiculo, int codigoMarca)
        {
            return await _http.HttpGet<List<ModeloModel>>($"https://brasilapi.com.br/api/fipe/veiculos/v1/{tipoVeiculo}/{codigoMarca}");
        }

        public async Task<ResponseGenerico<List<MunicipioModel>>> BuscarMunicipios(string siglaUF)
        {
            return await _http.HttpGet<List<MunicipioModel>>($"https://brasilapi.com.br/api/ibge/municipios/v1/{siglaUF}?providers=dados-abertos-br,gov,wikipedia");
        }

        public async Task<ResponseGenerico<List<EstadoModel>>> BuscarTodosEstados()
        {
            return await _http.HttpGet<List<EstadoModel>>($"https://brasilapi.com.br/api/ibge/uf/v1");
        }

        public async Task<ResponseGenerico<EstadoModel>> BuscarEstado(string siglaUF)
        {
            return await _http.HttpGet<EstadoModel>($"https://brasilapi.com.br/api/ibge/uf/v1/{siglaUF}");
        }

        public async Task<ResponseGenerico<IsbnModel>> BuscarLivro(string isbn)
        {
            return await _http.HttpGet<IsbnModel>($"https://brasilapi.com.br/api/isbn/v1/{isbn}");
        }

        public async Task<ResponseGenerico<List<NcmModel>>> BuscarTodosNcms()
        {
            return await _http.HttpGet<List<NcmModel>>($"https://brasilapi.com.br/api/ncm/v1");
        }

        public async Task<ResponseGenerico<List<NcmModel>>> BuscarNcmsPorFiltro(string filtro)
        {
            return await _http.HttpGet<List<NcmModel>>($"https://brasilapi.com.br/api/ncm/v1?search={filtro}");
        }

        public async Task<ResponseGenerico<NcmModel>> BuscarNcm(string codigo)
        {
            return await _http.HttpGet<NcmModel>($"https://brasilapi.com.br/api/ncm/v1/{codigo}");
        }

        public async Task<ResponseGenerico<List<PixParticipantesModel>>> BuscarParticipantesPix()
        {
            return await _http.HttpGet<List<PixParticipantesModel>>($"https://brasilapi.com.br/api/pix/v1/participants");
        }

        public async Task<ResponseGenerico<RegistroBrModel>> BuscarDadosDominio(string dominio)
        {
            return await _http.HttpGet<RegistroBrModel>($"https://brasilapi.com.br/api/registrobr/v1/{dominio}");
        }

        public async Task<ResponseGenerico<List<TaxaModel>>> BuscarTodasTaxas()
        {
            return await _http.HttpGet<List<TaxaModel>>($"https://brasilapi.com.br/api/taxas/v1");
        }

        public async Task<ResponseGenerico<TaxaModel>> BuscarTaxa(string sigla)
        {
            return await _http.HttpGet<TaxaModel>($"https://brasilapi.com.br/api/taxas/v1/{sigla}");
        }
    }
}
