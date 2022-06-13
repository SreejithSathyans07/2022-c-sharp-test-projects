using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controller
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "My first method";
        }
    }
}
