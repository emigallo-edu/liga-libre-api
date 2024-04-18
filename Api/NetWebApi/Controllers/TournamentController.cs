using Microsoft.AspNetCore.Mvc;
using Model.Services;

namespace NetWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TournamentController : Controller
    {
        private readonly CreateTournamentService _createTournamentService;

        public TournamentController(CreateTournamentService createTournamentService)
        {
            this._createTournamentService = createTournamentService;
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            try
            {
                await this._createTournamentService.ExecuteAsync();
                return Ok("Torneo creado correctamente");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}