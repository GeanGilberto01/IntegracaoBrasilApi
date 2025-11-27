using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DddController : ControllerBase
    {
        public readonly IDddService _dddService;

        public DddController(IDddService dddService)
        {
            _dddService = dddService;
        }

        [HttpGet("v1/Busca/Ddd/{ddd}")]
        [ProducesResponseType(typeof(CnpjResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarDdds([FromRoute] int ddd)
        {
            var response = await _dddService.BuscarDdds(ddd);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
