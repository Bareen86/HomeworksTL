using Hotels.Domain.Hotels;
using Hotels.Domain.Workers;
using Hotels.Infrastucture.Foundation;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Data.Workers
{
    internal class WorkerRepository : IWorkerRepository
    {
        private readonly HotelsDbContext _dbContext;
        private DbSet<Worker> _workers => _dbContext.Set<Worker>();

        public WorkerRepository(HotelsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public void DeleteWorker(Worker worker)
        {
            _workers.Remove(worker);
        }

        public List<Worker> GetAllWorkers()
        {
            return _workers.ToList();
        }

        public Worker GetWorkerById(int id)
        {
            return _workers.Where(r => r.Id == id).FirstOrDefault();
        }

        public void UpdateWorker(Worker worker)
        {
            var searchedWorker = GetWorkerById(worker.Id);
            searchedWorker.UpdateName(worker.Name);
            searchedWorker.UpdateSurname(worker.Surname);
        }
    }
}
