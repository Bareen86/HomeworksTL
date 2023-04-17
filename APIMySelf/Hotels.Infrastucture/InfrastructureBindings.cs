using Hotels.Domain.Hotels;
using Hotels.Domain.Workers;
using Hotels.Infrastructure.Data.Hotels;
using Hotels.Infrastructure.Data.Rooms;
using Hotels.Infrastructure.Data.Workers;
using Hotels.Infrastructure.Foundation;

using Microsoft.Extensions.DependencyInjection;

namespace Hotels.Infrastructure
{
    public static class InfrastructureBindings
    {
        public static IServiceCollection AddInfrastructure( this IServiceCollection service)
        {
            service.AddScoped<IHotelRepository, HotelRepository>();
            service.AddScoped<IRoomRepository, RoomRepository>();
            service.AddScoped<IWorkerRepository, WorkerRepository>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            return service;
        }
    }
}
