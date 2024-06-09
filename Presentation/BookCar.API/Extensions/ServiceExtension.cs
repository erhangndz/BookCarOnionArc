using BookCar.Application.Features.CQRS.Handlers.AboutHandlers;
using BookCar.Application.Features.CQRS.Handlers.BannerHandlers;
using BookCar.Application.Features.CQRS.Handlers.BrandHandlers;
using BookCar.Application.Features.CQRS.Handlers.CarHandlers;
using BookCar.Application.Interfaces;
using BookCar.Persistance.Repositories;

namespace BookCar.API.Extensions
{
    public static class ServiceExtension
    {

        public static void AddServiceHandlers(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<GetAboutQueryHandler>();
            services.AddScoped<GetAboutByIdQueryHandler>();
            services.AddScoped<UpdateAboutCommandHandler>();
            services.AddScoped<CreateAboutCommandHandler>();
            services.AddScoped<RemoveAboutCommandHandler>();


            services.AddScoped<GetBannerQueryHandler>();
            services.AddScoped<GetBannerByIdQueryHandler>();
            services.AddScoped<CreateBannerCommandHandler>();
            services.AddScoped<UpdateBannerCommandHandler>();
            services.AddScoped<RemoveBannerCommandHandler>();


            services.AddScoped<GetBrandQueryHandler>();
            services.AddScoped<GetBrandByIdQueryHandler>();
            services.AddScoped<CreateBrandCommandHandler>();
            services.AddScoped<UpdateBrandCommandHandler>();
            services.AddScoped<RemoveBrandCommandHandler>();


            services.AddScoped<GetCarQueryHandler>();
            services.AddScoped<GetCarByIdQueryHandler>();
            services.AddScoped<CreateCarCommandHandler>();
            services.AddScoped<UpdateCarCommandHandler>();
            services.AddScoped<RemoveCarCommandHandler>();
        }
    }
}
