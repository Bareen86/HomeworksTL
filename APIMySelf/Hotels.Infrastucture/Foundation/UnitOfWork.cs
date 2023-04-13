using Hotels.Infrastucture.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Infrastructure.Foundation
{
    public interface IUnitOfWork
    {
        void Commit();
    }
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly HotelsDbContext _dbContext;

        public UnitOfWork(HotelsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
