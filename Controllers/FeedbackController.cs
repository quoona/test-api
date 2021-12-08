using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.AspNetCore.Cors;
using test_api.FeedBack.Data.Repositories;
using FeedBack.Data.Models;

namespace Api.Controllers
{

    [ApiController]

    public class FeedbackController : ControllerBase
    {
        private readonly FeedBackRepository _feedbackRepository = new FeedBackRepository();
        [Route("[controller]")]
        [HttpGet]
        public IEnumerable<Feedback> Get()
        {
            return _feedbackRepository.GetAllFeedBack();
        }
    }
}