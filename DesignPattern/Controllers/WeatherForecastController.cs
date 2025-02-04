using DesignPattern.Behaviour_Design_Pattern.Command_design_pattern;
using DesignPattern.Behaviour_Design_Pattern.Observer_Design_pattern;
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

            IRestaurantActionListener preparePizza = new ActionPreparePizza();
            IRestaurantActionListener cookBurger = new ActionCookBurger();
            IRestaurantActionListener cookfood = new ActionCookfood();


            MenuOptionInvoker menuOptionInvoker = new MenuOptionInvoker();

            ChefReciever chefReciever = new ChefReciever();

            menuOptionInvoker.AddMenuOption("1", preparePizza);
            menuOptionInvoker.AddMenuOption("2", cookBurger);
            menuOptionInvoker.AddMenuOption("3", cookfood);

            menuOptionInvoker.InvokeMenuOption("1");
            menuOptionInvoker.InvokeMenuOption("2");


            Stores stores = new Stores();
            Logistics logistics = new Logistics();
            Purchase purchase = new Purchase();
            Product product = new Product();
            product.stocklevel = 15;
            product.Attach(stores);
            product.Attach(logistics);
            product.Attach(purchase);


            product.status = "Updated";


            product.Detach(logistics);
            product.stocklevel = 5;
            product.status = "Task Completed";

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
