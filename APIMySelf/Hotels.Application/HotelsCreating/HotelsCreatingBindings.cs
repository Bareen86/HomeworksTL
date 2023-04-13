using Microsoft.Extensions.DependencyInjection;

namespace Hotels.Application.HotelsCreathing
{
    public static class HotelsCreatingBindings
    {
        public static IServiceCollection AddHotelsCreator(this IServiceCollection services )
        {
            services.AddScoped<IHotelCreator, HotelCreator>();
            return services;
        }
    }
}
    