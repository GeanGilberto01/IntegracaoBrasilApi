using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PixController : ControllerBase
    {
        public readonly IPixService _pixService;

        public PixController(IPixService pixService)
        {
            _pixService = pixService;
        }

        [HttpGet("v1/Busca/Pix/Participantes")]
        [ProducesResponseType(typeof(List<PixParticipantesResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarParticipantesPix()
        {
            var response = await _pixService.BuscarParticipantesPix();

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
