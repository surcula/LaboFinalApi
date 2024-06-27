using LaboFinalAPIBLL.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaboFinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpellController(ISpellService spellService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() {
            return Ok(spellService.GetAll());
        }
    }
}
