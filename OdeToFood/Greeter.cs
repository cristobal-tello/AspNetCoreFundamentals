using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public class Greeter : IGreeter
    {
        string greeting;

        public Greeter(IConfiguration configuration)
        {
            greeting = configuration["Greeting"];
        }

        public string GetGreetting()
        {
            return greeting;
        }
    }
}
