using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FibonacciExcercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase
    {
        private readonly ILogger logger;
       

        public FibonacciController(ILogger<FibonacciController> logger)
        {
            this.logger = logger;
        }

        
        [HttpGet("{id:int}")]
        public int Get(int id)
        {
            return 0;
        }
    }
}
