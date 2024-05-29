using BookCar.Application.Features.CQRS.Commands.BannerCommands;
using BookCar.Application.Features.CQRS.Handlers.BannerHandlers;
using BookCar.Application.Features.CQRS.Queries.BannerQueries;
using Microsoft.AspNetCore.Mvc;

namespace BookCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(GetBannerQueryHandler _getBannerQueryHandler, GetBannerByIdQueryHandler _getBannerByIdQueryHandler,CreateBannerCommandHandler _createBannerCommandHandler,UpdateBannerCommandHandler _updateBannerCommandHandler,RemoveBannerCommandHandler _removeBannerCommandHandler) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _getBannerQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerCommand command)
        {
            await _createBannerCommandHandler.Handle(command);
            return Ok(command);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBannerCommand command)
        {
            await _updateBannerCommandHandler.Handle(command);
            return Ok("Banner Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _removeBannerCommandHandler.Handle(new RemoveBannerCommand(id));
            return Ok("Banner Silindi");
        }


    }
}
