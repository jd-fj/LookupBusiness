using Microsoft.EntityFrameworkCore;

namespace LookupBusiness.Models
{
  public class LookupBusinessContext : DbContext
  {
    public LookupBusinessContext(DbContextOptions<LookupBusinessContext> options)
      : base(options)
      {
      }

      
  }
}