using AstroAPI.Model;
using AstroAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AstroAPI.Controllers
{
    [Route("api/horoscopo")]
    [ApiController]
    public class HoroscopoController : ControllerBase
    {
        /// <summary>
        /// Busca a mensagem do dia do usuário
        /// </summary>
        /// <param name="username">Nickname do usuário cadastrado</param>
        /// <returns>Mensagem com a sorte do dia</returns>
        [HttpGet]
        [Route("mensagemDoDia")]
        public IActionResult SorteDoDia(string username)
        {
            var res = new BaseResponse();

            var user = UsuarioService.BuscarUsuario(username);
            if (user == null)
                return BadRequest(res.NotFoundResponse());

            var sorte = HoroscopoService.MensagemDoDia(user);
            return Ok(res.SuccessResponse(sorte));
        }
    }
}
