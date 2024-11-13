using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Security;
using System.Security.Claims;

namespace NetWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AuthorizedExamplesController : Controller
    {
        //[Authorize]
        [HttpGet("All")]
        public IActionResult All()
        {
          
            return Ok("Llamó correctamente al endpoint");
        }

        //[Authorize(Roles = Roles.USER)]
        [HttpGet("OnlyUser")]
        public IActionResult User()
        {
            return Ok("Llamó correctamente al endpoint de usuarios");
        }

        //[Authorize(Roles = Roles.USER)]
        [HttpGet("OnlyAdmin")]
        public IActionResult Admin()
        {
            return Ok("Llamó correctamente al endpoint de administradores");
        }
    }
}