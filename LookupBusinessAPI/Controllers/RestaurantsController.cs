using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LookupBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace LookupBusiness.Controllers
{
  [ApiVersion("1.0")]
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

  [ApiVersion("2.0")]
  [Route("api/{v:ApiVersion}/restaurants")]
  [ApiController]
  public class RestaurantsV2Controller : ControllerBase
  {
    private LookupBusinessContext _db;

    public RestaurantsV2Controller(LookupBusinessContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get(string name, string offerings, string nearestIntersection, int pricing)
    {
      var query = _db.Restaurants.AsQueryable();

      if(name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if(offerings != null)
      {
        query = query.Where(entry => entry.Offerings == offerings);
      }
      if(nearestIntersection != null)
      {
        query = query.Where(entry => entry.NearestIntersection == nearestIntersection);
      }
      if(pricing != 0)
      {
        query = query.Where(entry => entry.Pricing == pricing);
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
      _db.Restaurants.Remove(restaurantToDelete);
      _db.SaveChanges();
    }
  }
}