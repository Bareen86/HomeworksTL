using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.RoomsCreating
{
    public static class RoomsCreatingBindings
    {
        public static IServiceCollection AddRoomsCreator (this IServiceCollection services)
        {
            services.AddScoped<IRoomCreator, RoomCreator>();
            return services;
        }
    }
}
