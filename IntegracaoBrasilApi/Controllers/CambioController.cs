using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CambioController : ControllerBase
    {
        private readonly ICambioService _cambioService;

        public CambioController(ICambioService cambioService)
        {
            _cambioService = cambioService;
        }

        [HttpGet("v1/Busca/Cambio/Moeda")]
        [ProducesResponseType(typeof(List<MoedaResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarMoedas()
        {
            var response = await _cambioService.BuscarMoedas();

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Cambio/Moeda/{moeda}/{data}")]
        [ProducesResponseType(typeof(CambioResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCambio(string moeda, string data)
        {
            var response = await _cambioService.BuscarCambio(moeda, data);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

    }
}
