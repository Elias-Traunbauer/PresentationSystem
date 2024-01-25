using API.Models;
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

        [HttpPost]
        public IActionResult Post([FromServices] PresentationService presentationService, [FromBody] Presentation presentation)
        {
            var result = presentationService.AddPresentation(presentation);

            if (result)
            {
                return Ok(new
                {
                    Status = 200,
                });
            }
            else
            {
                return Ok(new
                {
                    Status = 400,
                    Errors = new Dictionary<string, string>()
                    {
                        { "Name","A presentation with this name already exists" }
                    }
                });
            }
        }
    }
}
