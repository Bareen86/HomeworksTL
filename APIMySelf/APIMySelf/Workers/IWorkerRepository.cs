using Hotels.Domain.Hotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Workers
{
    public interface IWorkerRepository
    {
        public List<Worker> GetAllWorkers();
        public void AddWorker(Worker worker);

        public void UpdateWorker(Worker worker);

        public void DeleteWorker(Worker worker);

        public Worker GetWorkerById(int id);
    }
}
