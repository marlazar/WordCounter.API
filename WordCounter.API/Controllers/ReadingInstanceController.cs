using Microsoft.AspNetCore.Mvc;
using WordCounter.Core.Models;
using WordCounter.Data.UnitOfWork;

namespace WordCounter.API.Controllers
{
    [Route("/api/instances")]
    public class ReadingInstanceController : ControllerBase
    {
        private readonly IUnitOfWork _iowUnitOfWork;

        public ReadingInstanceController(IUnitOfWork uow)
        {
            this._iowUnitOfWork = uow;
        }

        [HttpGet("")]
        public ActionResult ReturnAllInstances()
        {
            try
            {
                return Ok(_iowUnitOfWork.ReadingInstance.ReturnAllInstances());
            }
            catch (Exception)
            {
                return NotFound("There are no instances created!");
            }
        }

        [HttpGet("id")]
        public ActionResult ReturnReadingInstance(int instanceId)
        {
            try
            {
                return Ok(_iowUnitOfWork.ReadingInstance.ReturnReadingInstance(instanceId));
            }
            catch (Exception)
            {
                return NotFound("The instance doesn't exist!");
            }
        }

        [HttpPost("count")]
        public ActionResult CountWords([FromBody] ReadingInstanceDTO readingInstance)
        {
            try
            {
                int? wordCounter = 0;
                char[] delimiters = new char[] { ' ', '\r', '\n' };
                wordCounter = readingInstance.InstanceText?.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
                return Ok(wordCounter);
            }
            catch (Exception)
            {
                return NotFound("The number of words cannot be calculated. Please check your input!");
            }
        }
    }
}
