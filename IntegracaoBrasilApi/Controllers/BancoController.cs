using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        private readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/todos")]
        [ProducesResponseType(typeof(BancoResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodos()
        {
            var response = await _bancoService.BuscarTodos();

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

        [HttpGet("busca/{codigoBanco}")]
        [ProducesResponseType(typeof(BancoResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Buscar([RegularExpression("^[0-9]*$")] string codigoBanco)
        {
            var response = await _bancoService.BuscaBanco(codigoBanco);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }

    }
}
