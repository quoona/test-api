using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.AspNetCore.Cors;

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