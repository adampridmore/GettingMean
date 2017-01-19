using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WeatherScopesAngular.Controllers
{
    public class AppDataController : ApiController
    {
        [HttpGet]
        public List<Location> Get()
        {
            return Enumerable
                .Range(1, 10)
                .Select(i => new Location
                {
                    Name = $"Location_{i}",
                    Address = $"My Location {i} address",
                    Score = i % 6
                })
                .ToList();
        }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public int Score { get; set; }
    }
}
