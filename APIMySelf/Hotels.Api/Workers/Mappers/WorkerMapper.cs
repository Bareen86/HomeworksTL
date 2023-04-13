using Hotels.Api.Workers.Dtos;
using Hotels.Domain.Workers;

namespace Hotels.Api.Workers.Mappers
{
    public static class WorkerMapper
    {
        public static WorkerDto Map(this Worker worker)
        {
            return new WorkerDto
            {
                HotelId = worker.HotelId,
                Id = worker.Id,
                Name = worker.Name,
                SurName = worker.Surname,
            };
        }
    }
}
