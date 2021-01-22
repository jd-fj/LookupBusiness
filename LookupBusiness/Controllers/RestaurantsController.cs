using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LookupBusiness.Models;
using Microsoft.EntityFrameworkCore;

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

    // POST api/restaurants
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    // GET api/restaurants/1
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }

    // PUT api/restaurants/1
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/restaurants/1
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
      _db.Restaurants.Remove(restaurantToDelete);
      _db.SaveChanges();
    }
  }
}