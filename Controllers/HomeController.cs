using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hello_cloud_run_dotnet.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("hello")]
        [HttpGet]
        public string[] Hello()
        {
            return new String[] { "hello", "cloud", "run" };
        }

        [Route("hello/{you}")]
        [HttpGet]
        public string[] Hello(String you)
        {
            return new String[] { "hello", you };
        }
    }
}
