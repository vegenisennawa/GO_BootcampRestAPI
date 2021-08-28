using System;

namespace GO_BootcampRestAPI
{
    /// <summary>
    /// Class used to return "Hello world" message.
    /// </summary>
    public class HelloFriend
    {
        public string HelloWorldMessage { get; set; }
    }

    /// <summary>
    /// Class to return cat fact.
    /// </summary>
    public class GetCatFact
    {
        public string ErrorMessage { get; set; }
        public string Fact { get; set; }
    }

    /// <summary>
    /// Class to consume cat fact API.
    /// </summary>
    public class Respuesta
    {
        public bool BlnError { get; set; }
        public string ErrorMessage { get; set; }
        public string NormalResponse { get; set; }
    }
}
