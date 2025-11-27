using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistroBrController : ControllerBase
    {
        public readonly IRegistroBrService _registroBrService;

        public RegistroBrController(IRegistroBrService registroBrService)
        {
            _registroBrService = registroBrService;
        }

        [HttpGet("v1/Busca/Dominio/{dominio}")]
        [ProducesResponseType(typeof(RegistroBrResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarDadosDominio([FromRoute] string dominio)
        {
            var response = await _registroBrService.BuscarDadosDominio(dominio);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
