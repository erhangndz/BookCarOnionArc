using BookCar.Application.Features.Mediator.Commands.CarDetailCommands;
using BookCar.Application.Features.Mediator.Queries.CarDetailQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDetailsController(IMediator _mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _mediator.Send(new GetCarDetailQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _mediator.Send(new GetCarDetailByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCarDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok(command);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCarDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Araç Detayları Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveCarDetailCommand(id));
            return Ok("Araç Detayları Silindi");
        }
    }
}
