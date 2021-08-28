using System;
using GO_BootcampRestAPI.Modules;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

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

        /// <summary>
        /// Returns a basic "Hello world" message.
        /// </summary>
        /// <returns>"Hello world" message.</returns>
        [HttpGet]
        [Route("api/HelloWorld/")]
        public HelloFriend Get()
        {
            HelloFriend message = new();
            message.HelloWorldMessage = "Hello world";
            return message;
        }

        /// <summary>
        /// Get method to consume cat fact Rest API.
        /// This return a cat fact with no over 100 characters.
        /// </summary>
        /// <returns>cat fact class</returns>
        [HttpGet]
        [Route("api/GetCatFact")]
        public GetCatFact GetCatFact()
        {
            GetCatFact MewFact = new();

            Respuesta valor = new();

            try {
                valor = ConsumeAPIs.getItem("https://catfact.ninja/fact");
            }
            catch (Exception ex){
                valor.BlnError = true;
                valor.ErrorMessage = ex.Message;
                valor.NormalResponse = "";
            }
            finally {
                if (valor.BlnError)
                {
                    MewFact.ErrorMessage = valor.ErrorMessage;
                    MewFact.Fact = "";
                }
                else
                {
                    dynamic catFact = JsonConvert.DeserializeObject(valor.NormalResponse);

                    if(catFact.length > 100)
                    {
                        MewFact.ErrorMessage = "The fact is over 100 characters.";
                        MewFact.Fact = "";
                    }
                    else
                    {
                        MewFact.ErrorMessage = "";
                        MewFact.Fact = catFact.fact;
                    }
                }
            }

            return MewFact;
        }
    }
}
