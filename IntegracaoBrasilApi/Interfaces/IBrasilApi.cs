using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;
using static System.Net.WebRequestMethods;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();

        Task<ResponseGenerico<BancoModel>> BuscarBanco(int codigoBanco);

        Task<ResponseGenerico<List<MoedaModel>>> BuscarMoedas();

        Task<ResponseGenerico<CambioModel>> BuscarCambio(string moeda, string data);

        Task<ResponseGenerico<CepModel>> BuscarCep(int cep);

        Task<ResponseGenerico<CepModel>> BuscarCepV2(string cep);

        Task<ResponseGenerico<CnpjModel>> BuscarCnpj(string cnpj);

        Task<ResponseGenerico<List<CorretoraModel>>> BuscarTodasCorretoras();

        Task<ResponseGenerico<CorretoraModel>> BuscarCorretora(string cnpj);

        Task<ResponseGenerico<List<CidadeModel>>> BuscarTodasCidades();

        Task<ResponseGenerico<CidadeModel>> BuscarCidade(string nomeCidade);

        Task<ResponseGenerico<List<ClimaModel>>> BuscarCondicaoCapital();

        Task<ResponseGenerico<ClimaModel>> BuscarCondicaoAeroporto(string codicoIcao);

        Task<ResponseGenerico<PrevisaoModel>> BuscarPrevisaoMeteorologicaCidade(int codigoCidade);

        Task<ResponseGenerico<PrevisaoModel>> BuscarPrevisaoMeteorologicaCidadeDias(int codigoCidade, int dias);

        Task<ResponseGenerico<OndasModel>> BuscarPrevisaoOceanicaCidade(int codigoCidade);

        Task<ResponseGenerico<OndasModel>> BuscarPrevisaoOceanicaCidadeDias(int codigoCidade, int dias);

        Task<ResponseGenerico<DddModel>> BuscarDdds(int ddd);

        Task<ResponseGenerico<List<FeriadoModel>>> BuscarFeriados(int ano);

        Task<ResponseGenerico<List<MarcaModel>>> BuscarVeiculosMarcas(string tipoVeiculo);

        Task<ResponseGenerico<List<PrecoModel>>> BuscarVeiculosPreco(string codigoFipe);

        Task<ResponseGenerico<List<TabelaModel>>> BuscarTabelasFipe();

        Task<ResponseGenerico<List<ModeloModel>>> BuscarVeiculosModelos(string tipoVeiculo, int codigoMarca);

        Task<ResponseGenerico<List<MunicipioModel>>> BuscarMunicipios(string siglaUF);

        Task<ResponseGenerico<List<EstadoModel>>> BuscarTodosEstados();

        Task<ResponseGenerico<EstadoModel>> BuscarEstado(string siglaUF);

        Task<ResponseGenerico<IsbnModel>> BuscarLivro(string isbn);

        Task<ResponseGenerico<List<NcmModel>>> BuscarTodosNcms();

        Task<ResponseGenerico<List<NcmModel>>> BuscarNcmsPorFiltro(string filtro);

        Task<ResponseGenerico<NcmModel>> BuscarNcm(string codigo);

        Task<ResponseGenerico<List<PixParticipantesModel>>> BuscarParticipantesPix();

        Task<ResponseGenerico<RegistroBrModel>> BuscarDadosDominio(string dominio);

        Task<ResponseGenerico<List<TaxaModel>>> BuscarTodasTaxas();

        Task<ResponseGenerico<TaxaModel>> BuscarTaxa(string sigla);
    }
}
