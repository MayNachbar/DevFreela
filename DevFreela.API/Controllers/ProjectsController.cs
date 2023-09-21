using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
       // api/projects?query=net core
        [HttpGet]
        // Buscar ou filtrar todos os projetos
        public IActionResult Get(string query)
        {
            return Ok();
        }
    }
}
