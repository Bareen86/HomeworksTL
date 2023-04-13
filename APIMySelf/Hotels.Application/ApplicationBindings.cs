using Hotels.Application.HotelsCreathing;
using Hotels.Application.HotelsRemover;
using Hotels.Application.HotelsUpdating;
using Hotels.Application.RoomsCreating;
using Hotels.Application.RoomsDeleting;
using Hotels.Application.RoomsUpdatinng;
using Hotels.Application.WorkersCreating;
using Hotels.Application.WorkersUpdating;
using Microsoft.Extensions.DependencyInjection;

namespace Hotels.Application
{
    public static class ApplicationBindings
    {
        public static IServiceCollection AddAplication( this IServiceCollection services)
        {
            services.AddHotelsCreator();
            services.AddHotelsEditor();
            services.AddHotelsRemover();
            services.AddRoomsCreator();
            services.AddRoomsEditor();
            services.AddRoomsRemover();
            services.AddWorkerCreator();
            services.AddWorkerEditor();
            return services;
        }
    }
}
