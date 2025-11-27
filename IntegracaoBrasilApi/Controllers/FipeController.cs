using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FipeController : ControllerBase
    {
        public readonly IFipeService _fipeService;

        public FipeController(IFipeService fipeService)
        {
            _fipeService = fipeService;
        }

        [HttpGet("v1/Busca/Marca/{tipoVeiculo}")]
        [ProducesResponseType(typeof(List<MarcaResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarVeiculosMarcas([FromRoute] string tipoVeiculo)
        {
            var response = await _fipeService.BuscarVeiculosMarcas(tipoVeiculo);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Preco/{codigoFipe}")]
        [ProducesResponseType(typeof(List<PrecoResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarVeiculosPreco([FromRoute] string codigoFipe)
        {
            var response = await _fipeService.BuscarVeiculosPreco(codigoFipe);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Tabela/Fipe")]
        [ProducesResponseType(typeof(List<TabelaResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTabelasFipe()
        {
            var response = await _fipeService.BuscarTabelasFipe();

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Modelo/{tipoVeiculo}/{codigoMarca}")]
        [ProducesResponseType(typeof(List<ModeloResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarVeiculosModelos([FromRoute] string tipoVeiculo, int codigoMarca)
        {
            var response = await _fipeService.BuscarVeiculosModelos(tipoVeiculo, codigoMarca);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
