using BookCar.Application.Features.Mediator.Commands.FeatureCommands;
using BookCar.Application.Features.Mediator.Queries.FeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController(IMediator _mediator) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _mediator.Send(new GetFeatureQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _mediator.Send(new GetFeatureByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok(command);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok(command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveFeatureCommand(id));
            return Ok("Özellik Silindi");
        }

    }
}
