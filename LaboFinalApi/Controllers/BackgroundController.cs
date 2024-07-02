using LaboFinalAPIBLL.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaboFinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BackgroundController(IBackgroundService backgroundService) : ControllerBase
    {
        
        // GET: api/<FeatsController>
        /// <summary>
        /// return all background
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(backgroundService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
