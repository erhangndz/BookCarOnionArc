using BookCar.Application.Features.CQRS.Commands.BrandCommands;
using BookCar.Application.Features.CQRS.Handlers.BrandHandlers;
using BookCar.Application.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController(GetBrandQueryHandler _getBrandQueryHandler, GetBrandByIdQueryHandler _getBrandByIdQueryHandler,CreateBrandCommandHandler _createBrandCommandHandler,UpdateBrandCommandHandler _updateBrandCommandHandler, RemoveBrandCommandHandler _removeBrandCommandHandler) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _getBrandQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBrandCommand command)
        {
            await _createBrandCommandHandler.Handle(command);
            return Ok(command);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBrandCommand command)
        {
            await _updateBrandCommandHandler.Handle(command);
            return Ok("Marka Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return Ok("Marka Silindi");
        }

    }
}
