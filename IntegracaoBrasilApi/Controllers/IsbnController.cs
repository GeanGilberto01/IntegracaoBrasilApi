using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IsbnController : ControllerBase
    {
        public readonly IIsbnService _isbnService;

        public IsbnController(IIsbnService isbnService)
        {
            _isbnService = isbnService;
        }

        [HttpGet("v1/Busca/Livro/{isbn}")]
        [ProducesResponseType(typeof(IsbnResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarLivro([FromRoute] string isbn)
        {
            var response = await _isbnService.BuscarLivro(isbn);

            return (response.CodigoHttp == HttpStatusCode.OK) ? Ok(response.Dados) : StatusCode((int)response.CodigoHttp, response.Erro);
        }
    }
}
