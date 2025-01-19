using DesignPattern.Creational_Design_Pattern.AbstractFactory;
using DesignPattern.Creational_Design_Pattern.Builder_Design_Pattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            HolidayPackageDirector director = new HolidayPackageDirector();
            HolidayPAckageBuilder builder = new BudgetHolidayPackage();
            HolidayPAckageBuilder luxuryBuilder = new LuxuryHolidayPackage();

            HolidayPackage luxuryHolidayPackage = director.BuildHolidayPackage(luxuryBuilder);
            HolidayPackage holidayPackage = director.BuildHolidayPackage(builder);
            holidayPackage.display();
            luxuryHolidayPackage.display();





            IAuthentication_Factory factory = new AuthenticationFactory.AppleAuthentication();


            IOAuth oAuth = factory.CreateOAuth();
            IMFA mfa = factory.CreateMFA();
            IBasic basic = factory.CreateBasic();
            oAuth.Authenticate();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
