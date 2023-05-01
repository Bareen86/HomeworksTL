using Hotels.Api.Workers.Dtos;
using Hotels.Api.Workers.Mappers;
using Hotels.Application.WorkersCreating;
using Hotels.Application.WorkersUpdating;
using Hotels.Domain.Hotels;
using Hotels.Domain.Workers;
using Hotels.Infrastructure.Foundation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Api.Workers.Controllers
{
    [Route("api/")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        private readonly IWorkerRepository _workerRepository;
        private readonly IWorkerCreator _workerCreator;
        private readonly IWorkerEditor _workerEditor;
        private readonly IUnitOfWork _unitOfWork;

        public WorkersController(
            IWorkerRepository workerRepository,
            IWorkerCreator workerCreator,
            IWorkerEditor workerEditor,
            IUnitOfWork unitOfWork)
        {
            _workerRepository = workerRepository;
            _workerCreator = workerCreator;
            _workerEditor = workerEditor;   
            _unitOfWork = unitOfWork;
        }

        [HttpGet("Hotels/Workers")]
        public IActionResult GetAllWorkers()
        {
            var map = _workerRepository.GetAllWorkers().Select(w => w.Map());
            if(map == null)
            {
                return BadRequest();
            }
            return Ok(map);
        }
        [HttpGet("Hotels/{hotelid}/Workers")]
        public IActionResult GetHotelWorkers([FromRoute] int hotelid)
        {
            var workers = _workerRepository.GetAllWorkers().Where(r => r.HotelId == hotelid);
            var map = _workerRepository.GetAllWorkers().Select(w => w.Map());
            return Ok(map);
        }
        [HttpPost("Hotels/{hotelid}/Workers")]
        public IActionResult Add([FromRoute] int hotelid, [FromBody] AddWorkerCommandDto command)
        {
            Worker worker = new(command.Name, command.SurName, hotelid);
            _workerCreator.Add(worker);
            _unitOfWork.Commit();
            return Ok();
        }
        [HttpPut("Hotels/{hotelid}/Workers/{workerid}")]
        public IActionResult GetHotelWorker([FromRoute] int hotelid, [FromRoute] int workerid, UpdateWorkerCommandDto command)
        {
            Worker worker = _workerRepository.GetAllWorkers().Single(r => r.Id == workerid && r.HotelId == hotelid);
            worker.UpdateName(command.Name);
            worker.UpdateSurname(command.SurName);
            _workerEditor.Update(worker);
            _unitOfWork.Commit();
            return Ok();
        }
        [HttpDelete("Hotels/{hotelid}/Workers/{workerid}")]
        public IActionResult DeleteWorker([FromRoute] int workerid)
        {
            var worker = _workerRepository.GetAllWorkers().Where(r => r.Id == workerid).FirstOrDefault();
            _workerRepository.DeleteWorker(worker);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}
