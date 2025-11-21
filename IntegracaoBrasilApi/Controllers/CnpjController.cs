using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CnpjController : ControllerBase
    {
        public readonly ICnpjService _cnpjService;

        public CnpjController(ICnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }

        [HttpGet("Buscar/{cnpj}")]
        [ProducesResponseType(typeof(CnpjResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCnpj([FromRoute] string cnpj)
        {
            var response = await _cnpjService.BuscarCnpj(cnpj);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
