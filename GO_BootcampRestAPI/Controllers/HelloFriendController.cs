using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GO_BootcampRestAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HelloFriendController : ControllerBase
    {
        private readonly ILogger<HelloFriendController> _logger;

        public HelloFriendController(ILogger<HelloFriendController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public HelloFriend get()
        {
            HelloFriend message = new HelloFriend();
            message.HelloWorldMessage = "Hello world";
            return message;
        }
    }
}
