using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.HotelsRemover
{
    public static class HotelsDeletingBindings
    {
        public static IServiceCollection AddHotelsRemover(this IServiceCollection services)
        {
            services.AddScoped<IHotelRemover, HotelRemover>();
            return services;
        }
    }
}
