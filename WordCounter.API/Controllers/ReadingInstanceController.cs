using Microsoft.AspNetCore.Mvc;
using WordCounter.Data.UnitOfWork;

namespace WordCounter.API.Controllers
{
    public class ReadingInstanceController : ControllerBase
    {
        private readonly IUnitOfWork uow;

        public ReadingInstanceController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpGet]
        [Route("/api/instances")]
        public ActionResult ReturnAllInstances()
        {
            try
            {
                return Ok(uow.ReadingInstance.ReturnAllInstances());
            }
            catch (Exception e)
            {
                return NotFound("Error in input.");
                throw;
            }
        }

        [HttpGet]
        [Route("/api/instances/{instanceId}")]
        public ActionResult ReturnReadingInstance(int instanceId)
        {
            try
            {
                return (Ok(uow.ReadingInstance.ReturnReadingInstance(instanceId)));
            }
            catch (Exception e)
            {
                return NotFound("Error in input.");
                throw;
            }
        }
    }
}
