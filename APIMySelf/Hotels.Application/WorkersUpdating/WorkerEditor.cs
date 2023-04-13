using Hotels.Domain.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.WorkersUpdating
{
    public interface IWorkerEditor
    {
        void Update(Worker worker);
    }
    public class WorkerEditor : IWorkerEditor
    {
        private readonly IWorkerRepository _workerRepository;

        public WorkerEditor(IWorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public void Update(Worker worker)
        {
            _workerRepository.UpdateWorker(worker);
        }
    }
}
