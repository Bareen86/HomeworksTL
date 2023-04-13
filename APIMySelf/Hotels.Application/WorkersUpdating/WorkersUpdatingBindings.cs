using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.WorkersUpdating
{
    public static class WorkersUpdatingBindings
    {
        public static IServiceCollection AddWorkerEditor(this IServiceCollection services)
        {
            services.AddScoped<IWorkerEditor, WorkerEditor>();
            return services;
        }
    }
}
