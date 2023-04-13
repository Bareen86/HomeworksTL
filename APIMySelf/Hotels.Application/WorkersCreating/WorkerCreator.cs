using Hotels.Domain.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.WorkersCreating
{
    public interface IWorkerCreator
    {
        void Add(Worker worker);
    }
    public class WorkerCreator : IWorkerCreator
    {
        private readonly IWorkerRepository _workerRepository;

        public WorkerCreator(IWorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public void Add(Worker worker)
        {
            _workerRepository.AddWorker(worker);
        }
    }
}
