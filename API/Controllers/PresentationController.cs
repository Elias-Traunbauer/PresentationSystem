using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/presentation")]
    public class PresentationController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromServices] PresentationService presentationService)
        {
            return Ok(presentationService.GetPresentations());
        }
    }
}
