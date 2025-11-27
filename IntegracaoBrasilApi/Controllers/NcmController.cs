using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NcmController : ControllerBase
    {
        public readonly INcmService _ncmService;

        public NcmController(INcmService ncmService)
        {
            _ncmService = ncmService;
        }

        [HttpGet("v1/Busca/Ncm")]
        [ProducesResponseType(typeof(List<NcmResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodosNcms()
        {
            var response = await _ncmService.BuscarTodosNcms();

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Ncm/{filtro}")]
        [ProducesResponseType(typeof(List<NcmResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarNcmsPorFiltro([FromRoute] string filtro)
        {
            var response = await _ncmService.BuscarNcmsPorFiltro(filtro);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Ncm/Codigo/{codigo}")]
        [ProducesResponseType(typeof(NcmResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarNcm([FromRoute] string codigo)
        {
            var response = await _ncmService.BuscarNcm(codigo);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
