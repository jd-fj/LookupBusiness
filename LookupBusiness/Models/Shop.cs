using System.ComponentModel.DataAnnotations;

namespace LookupBusiness.Models
{
  public class Shop
  {
    public int ShopId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength(200)]
    public string Offerings { get; set; }
    [Required]
    public string NearestIntersection { get; set; }
    [Required]
    [Range(1, 5, ErrorMessage = "1 being affordable, 5 being super expensive")]
    public int Pricing { get; set; }
  }
}