using LaboFinalAPIBLL.Interfaces.Services;
using LaboFinalAPIBLL.Services;
using LaboFinalAPIDomain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaboFinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatController(IFeatsService featsService) : ControllerBase
    {
        // GET: api/<FeatsController>
        /// <summary>
        /// return all feat
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
                return Ok(featsService.GetAll());
            }            
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<FeatsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FeatsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FeatsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FeatsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
