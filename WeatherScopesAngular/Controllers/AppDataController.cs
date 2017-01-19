using System.Collections.Generic;
using System.Web.Http;

namespace WeatherScopesAngular.Controllers
{
    public class AppDataController : ApiController
    {
        [HttpGet]
        public List<Location> Get()
        {
            return new List<Location>
            {
                new Location {Name = "My Location 1", Address = "My location 1 address"},
                new Location {Name = "My Location 2", Address = "My location 2 address"}
            };
        }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
