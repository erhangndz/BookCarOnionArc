using BookCar.Application.Features.CQRS.Commands.AboutCommands;
using BookCar.Application.Features.CQRS.Handlers.AboutHandlers;
using BookCar.Application.Features.CQRS.Queries.AboutQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(CreateAboutCommandHandler createAboutCommandHandler,GetAboutByIdQueryHandler getAboutByIdQueryHandler, GetAboutQueryHandler getAboutQueryHandler, RemoveAboutCommandHandler removeAboutCommandHandler, UpdateAboutCommandHandler updateAboutCommandHandler) : ControllerBase
    {


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await getAboutQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutCommand command)
        {
             await createAboutCommandHandler.Handle(command);
            return Ok("Hakkımda Alanı Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await removeAboutCommandHandler.Handle(new RemoveAboutCommand(id));
            return Ok("Hakkımda Alanı Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutCommand command)
        {
            await updateAboutCommandHandler.Handle(command);
            return Ok("Hakkımda Alanı Güncellendi");
        }

    }
}
