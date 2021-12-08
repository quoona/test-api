using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        [HttpGet(Name = "GetString")]
        public string Get()
        {
            return "HeluCabeo";
        }
    }
}