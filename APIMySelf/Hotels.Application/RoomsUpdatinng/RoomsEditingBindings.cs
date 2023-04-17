using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.RoomsUpdatinng
{
    public static class RoomsEditingBindings
    {
        public  static IServiceCollection AddRoomsEditor(this IServiceCollection services)
        {
            services.AddScoped<IRoomsEditor, RoomsEditor>();
            return services;
        }
    }
}
