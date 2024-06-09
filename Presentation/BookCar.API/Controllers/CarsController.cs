
using BookCar.Application.Features.CQRS.Commands.CarCommands;
using BookCar.Application.Features.CQRS.Handlers.CarHandlers;
using BookCar.Application.Features.CQRS.Queries.CarQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController(GetCarQueryHandler _getCarQueryHandler, GetCarByIdQueryHandler _getCarByIdQueryHandler, CreateCarCommandHandler _createCarCommandHandler, UpdateCarCommandHandler _updateCarCommandHandler, RemoveCarCommandHandler _removeCarCommandHandler) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _getCarQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCarCommand command)
        {
            await _createCarCommandHandler.Handle(command);
            return Ok(command);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok("Araba Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return Ok("Araba Silindi");
        }
    }
}
