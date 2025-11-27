using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CorretoraController : ControllerBase
    {
        public readonly ICorretoraService _corretoraService;

        public CorretoraController(ICorretoraService corretoraService)
        {
            _corretoraService = corretoraService;
        }

        [HttpGet("v1/Busca/Corretora")]
        [ProducesResponseType(typeof(List<CorretoraResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodasCorretoras()
        {
            var response = await _corretoraService.BuscarTodasCorretoras();

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("v1/Busca/Corretora/{cnpj}")]
        [ProducesResponseType(typeof(CorretoraResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCorretora([FromRoute] string cnpj)
        {
            var response = await _corretoraService.BuscarCorretora(cnpj);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
