using Hotels.Infrastructure.Data.Hotels;
using Hotels.Infrastructure.Data.Rooms;
using Hotels.Infrastructure.Data.Workers;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Hotels.Infrastucture.Foundation
{
    public class HotelsDbContext : DbContext
    {
        public HotelsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
