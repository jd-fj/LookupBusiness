using Microsoft.EntityFrameworkCore;

namespace ProjectNameApi.Models
{
  public class ProjectNameApiContext : DbContext
  {
    public ProjectNameApiContext(DbContextOptions<ProjectNameApiContext> options)
      : base(options)
      {
      }

      
  }
}