using LaboFinalAPIBLL.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaboFinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController(IClassesService classesService) : ControllerBase
    {

        /// <summary>
        /// return all Class
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(classesService.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }


        /// <summary>
        /// return class by id
        /// </summary>
        /// <param name="id">Class Id</param>
        /// <returns>class by id</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetById([FromRoute]int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid ID");
                }
                return Ok(classesService.GetById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

    }
}
