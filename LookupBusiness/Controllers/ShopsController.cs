using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LookupBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace LookupBusiness.Controllers
{
  // [ApiVersion("1.0")]
  [Route("api/Shops")]
  [ApiController]
  public class ShopsV1Controller : ControllerBase
  {
    private LookupBusinessContext _db;

    public ShopsV1Controller(LookupBusinessContext db)
    {
      _db = db;
    }

    // GET api/Shops
    [HttpGet]
    public ActionResult<IEnumerable<Shop>> Get()
    {
      return _db.Shops.ToList();
    }

    // POST api/Shops
    [HttpPost]
    public void Post([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }

    // GET api/Shops/1
    [HttpGet("{id}")]
    public ActionResult<Shop> Get(int id)
    {
      return _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
    }

    // PUT api/Shops/1
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shop shop)
    {
      shop.ShopId = id;
      _db.Entry(shop).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/Shops/1
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var shopToDelete = _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
      _db.Shops.Remove(shopToDelete);
      _db.SaveChanges();
    }
  }
}