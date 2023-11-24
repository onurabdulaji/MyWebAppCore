using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Mediator.Commands.AboutCommands;
using Project.BusinessLayer.Mediator.Queries.AboutQuery;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAboutList()
        {
            var aboutList = await _mediator.Send(new GetAboutQuery());
            return Ok(aboutList);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand createAboutCommand)
        {
            await _mediator.Send(createAboutCommand);
            return Ok("About Basarili Bir Sekilde Eklendi");
        }
    }
}
