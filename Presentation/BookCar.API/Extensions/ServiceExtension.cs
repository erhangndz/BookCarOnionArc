using BookCar.Application.Features.CQRS.Handlers.AboutHandlers;
using BookCar.Application.Interfaces;
using BookCar.Persistance.Repositories;

namespace BookCar.API.Extensions
{
    public static class ServiceExtension
    {

        public static void AddServiceExtensions(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<GetAboutQueryHandler>();
            services.AddScoped<GetAboutByIdQueryHandler>();
            services.AddScoped<UpdateAboutCommandHandler>();
            services.AddScoped<CreateAboutCommandHandler>();
            services.AddScoped<RemoveAboutCommandHandler>();
        }
    }
}
