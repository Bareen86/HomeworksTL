using Hotels.Domain.Workers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.WorkersCreating
{
    public static class WorkersCreatingBindings
    {
        public static IServiceCollection AddWorkerCreator(this IServiceCollection services)
        {
            services.AddScoped<IWorkerCreator, WorkerCreator>();
            return services;
        }
    }
}
