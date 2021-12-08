using Microsoft.AspNetCore.Mvc;
using API.Models;
namespace Api.Controllers
{

    [ApiController]

    public class FeedbackController : ControllerBase
    {
        [Route("[controller]")]
        [HttpGet]
        public IEnumerable<Feedback> Get()
        {
            return Feedback.FeedbackList;
        }
    }
}