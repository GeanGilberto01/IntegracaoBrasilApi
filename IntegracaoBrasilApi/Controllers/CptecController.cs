using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CptecController : ControllerBase
    {
        public readonly ICptecService _cptecService;

        public CptecController(ICptecService cptecService)
        {
            _cptecService = cptecService;
        }

        [HttpGet("v1/Busca/Cidade")]
        [ProducesResponseType(typeof(List<CidadeResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodasCidades()
        {
            var response = await _cptecService.BuscarTodasCidades();

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Cidade/{nomeCidade}")]
        [ProducesResponseType(typeof(CidadeResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCnpj([FromRoute] string nomeCidade)
        {
            var response = await _cptecService.BuscarCidade(nomeCidade);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Condicao/Capital")]
        [ProducesResponseType(typeof(List<ClimaResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCondicaoCapital()
        {
            var response = await _cptecService.BuscarCondicaoCapital();

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Condicao/Aeroporto/{codicoIcao}")]
        [ProducesResponseType(typeof(ClimaResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCondicaoAeroporto([FromRoute] string codicoIcao)
        {
            var response = await _cptecService.BuscarCondicaoAeroporto(codicoIcao);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Previsao/Meteorologica/{codigoCidade}")]
        [ProducesResponseType(typeof(PrevisaoResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarPrevisaoMeteorologicaCidade([FromRoute] int codigoCidade)
        {
            var response = await _cptecService.BuscarPrevisaoMeteorologicaCidade(codigoCidade);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Previsao/Meteorologica/{codigoCidade}/{dias}")]
        [ProducesResponseType(typeof(PrevisaoResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarPrevisaoMeteorologicaCidadeDias([FromRoute] int codigoCidade, int dias)
        {
            var response = await _cptecService.BuscarPrevisaoMeteorologicaCidadeDias(codigoCidade, dias);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Previsao/Oceanica/{codigoCidade}")]
        [ProducesResponseType(typeof(OndasResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarPrevisaoOceanicaCidade([FromRoute] int codigoCidade)
        {
            var response = await _cptecService.BuscarPrevisaoOceanicaCidade(codigoCidade);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Previsao/Oceanica/{codigoCidade}/{dias}")]
        [ProducesResponseType(typeof(OndasResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarPrevisaoOceanicaCidadeDias([FromRoute] int codigoCidade, int dias)
        {
            var response = await _cptecService.BuscarPrevisaoOceanicaCidadeDias(codigoCidade, dias);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
