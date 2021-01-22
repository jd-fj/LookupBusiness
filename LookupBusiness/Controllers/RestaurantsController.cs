using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LookupBusiness.Models;

namespace LookupBusiness.Controllers
{
  // [ApiVersion("1.0")]
  [Route("api/restaurants")]
  [ApiController]
  public class RestaurantsV1Controller : ControllerBase
  {
    private LookupBusinessContext _db;

    public RestaurantsV1Controller(LookupBusinessContext db)
    {
      _db = db;
    }

    // GET api/restaurants
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get()
    {
      return _db.Restaurants.ToList();
    }

    // GET api/restaurants/3
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }

    // POST api/restaurants
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }
  }
}