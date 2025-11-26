using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface ICptecService
    {
        Task<ResponseGenerico<List<CidadeResponse>>> BuscarTodasCidades();

        Task<ResponseGenerico<CidadeResponse>> BuscarCidade(string nomeCidade);

        Task<ResponseGenerico<List<ClimaResponse>>> BuscarCondicaoCapital();

        Task<ResponseGenerico<ClimaResponse>> BuscarCondicaoAeroporto(string codicoIcao);

        Task<ResponseGenerico<PrevisaoResponse>> BuscarPrevisaoMeteorologicaCidade(int codigoCidade);

        Task<ResponseGenerico<PrevisaoResponse>> BuscarPrevisaoMeteorologicaCidadeDias(int codigoCidade, int dias);

        Task<ResponseGenerico<OndasResponse>> BuscarPrevisaoOceanicaCidade(int codigoCidade);

        Task<ResponseGenerico<OndasResponse>> BuscarPrevisaoOceanicaCidadeDias(int codigoCidade, int dias);
    }
}
