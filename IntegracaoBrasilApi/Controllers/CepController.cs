using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CepController : ControllerBase
    {
        public readonly ICepService _enderecoService;

        public CepController(ICepService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet("Buscar/{cep}")]
        [ProducesResponseType(typeof(CepResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCep([FromRoute] int cep)
        {
            var response = await _enderecoService.BuscarCep(cep);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("Buscar/V2/{cep}")]
        [ProducesResponseType(typeof(CepResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCepV2([FromRoute] string cep)
        {
            var response = await _enderecoService.BuscarCepV2(cep);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
