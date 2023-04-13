using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.RoomsDeleting
{
    public static class RoomsDeleteingBindings
    {
        public static IServiceCollection AddRoomsRemover(this IServiceCollection services)
        {
            services.AddScoped<IRoomRemover, RoomsRemover>();
            return services;
        }
    }
}
