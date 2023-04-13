using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotels.Application.HotelsCreathing;
using Microsoft.Extensions.DependencyInjection;

namespace Hotels.Application.HotelsUpdating
{
    public static class HotelsUpdatingBindings
    {
        public static IServiceCollection AddHotelsEditor(this IServiceCollection services)
        {
            services.AddScoped<IHotelEditor, HotelEditor>();
            return services;
        }
    }
}
